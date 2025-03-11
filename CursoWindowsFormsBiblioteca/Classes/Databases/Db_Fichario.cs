using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.Classes.Databases
{
    public class Db_Fichario
    {
        public string diretorio;
        public string mensagem;
        public bool status;

        public Db_Fichario(string Diretorio) 
        {
            status = true;
            try
            {
                if (!Directory.Exists(Diretorio))
                {
                    Directory.CreateDirectory(Diretorio);
                }
                diretorio = Diretorio;
                mensagem = "Conexão com o Fichário criada com sucesso!";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = $"Conexão com Erro, {ex.Message}";
            }

        }

        public void incluir(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                if (File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    mensagem = "Inclusão não permitida pois o ID já existe: " + Id;
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + Id + ".json", jsonUnit);
                    mensagem = "Inclusão efetuada com sucesso: " + Id;
                }
            }
            catch(Exception ex)
            {
                status = false;
                mensagem = $"Conexão com Erro, {ex.Message}";
            }

        }

    }
}
