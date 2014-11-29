using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Inovix.Data.Fabrica;

namespace Inovix.Data.Servico
{
    public class RepositorioAccont
    {
        public const string NomeArquivo = "D://DadosAccount.xml";

        public void InicializarRepositorioAccont()
        {
            if (File.Exists(NomeArquivo))
            {
                File.Delete(NomeArquivo);
            }

            Salvar(FabricaAccount.ListaAccounts().ToList());   
        }

        public List<Account> RetornaAccounts()
        {
            var accounts = new List<Account>();
            var ser = new XmlSerializer(typeof(List<Account>));
            var fs = new FileStream(NomeArquivo, FileMode.OpenOrCreate);
            try
            {
                accounts = ser.Deserialize(fs) as List<Account>;
            }
            catch (InvalidOperationException)
            {
                if (accounts != null)
                    ser.Serialize(fs, accounts);
            }
            finally
            {
                fs.Close();
            }
            return accounts;
        }

        private void Salvar(List<Account> accounts)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Account>));
            FileStream fs = new FileStream(NomeArquivo, FileMode.OpenOrCreate);
            ser.Serialize(fs, accounts);
            fs.Close();
        }

        public void Inserir(Account customer)
        {
            List<Account> listuUsuarios = RetornaAccounts();
            int id = 1;

            if (listuUsuarios.Any())
            {
                id = id + listuUsuarios.Max(u => u.IdAccount);
            }

            customer.IdAccount = id;

            listuUsuarios.Add(customer);
            Salvar(listuUsuarios);
        }

        public void Editar(Account customer)
        {
            List<Account> accounts = RetornaAccounts().Select(item => item.IdAccount == customer.IdAccount ? customer : item).ToList();

            Salvar(accounts);
        }

        public void Deletar(int id)
        {
            List<Account> accounts = RetornaAccounts().ToList();
            accounts.Remove(accounts.First(u => u.IdAccount == id));
            Salvar(accounts);
        }
    }
}
