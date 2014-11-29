using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Inovix.Data.Fabrica;

namespace Inovix.Data.Servico
{
    public class RepositorioCustomer
    {
        public const string NomeArquivo = "D://DadosCustomer.xml";

        public RepositorioCustomer()
        {
            if (File.Exists(NomeArquivo))
            {
                File.Delete(NomeArquivo);
            }

            Salvar(FabricaCustomer.ListaCustomers().ToList());   
        }

        public static List<Customer> RetornaUsuarios()
        {
            var usuarios = new List<Customer>();
            var ser = new XmlSerializer(typeof(List<Customer>));
            var fs = new FileStream(NomeArquivo, FileMode.OpenOrCreate);
            try
            {
                usuarios = ser.Deserialize(fs) as List<Customer>;
            }
            catch (InvalidOperationException ex)
            {
                if (usuarios != null)
                    ser.Serialize(fs, usuarios);
            }
            finally
            {
                fs.Close();
            }
            return usuarios;
        }

        private static void Salvar(List<Customer> usuarios)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Customer>));
            FileStream fs = new FileStream(NomeArquivo, FileMode.OpenOrCreate);
            ser.Serialize(fs, usuarios);
            fs.Close();
        }

        public static void Inserir(Customer customer)
        {
            List<Customer> listuUsuarios = RetornaUsuarios();
            int id = 1;

            if (listuUsuarios.Any())
            {
                id = id + listuUsuarios.Max(u => u.IdCustomer);
            }

            customer.IdCustomer = id;

            listuUsuarios.Add(customer);
            Salvar(listuUsuarios);
        }

        public static void Editar(Customer customer)
        {
            List<Customer> usuarios = RetornaUsuarios().Select(item => item.IdCustomer == customer.IdCustomer ? customer : item).ToList();

            Salvar(usuarios);
        }

        public static void Deletar(int id)
        {
            List<Customer> usuarios = RetornaUsuarios().ToList();
            usuarios.Remove(usuarios.First(u => u.IdCustomer == id));
            Salvar(usuarios);
        }
    }
}
