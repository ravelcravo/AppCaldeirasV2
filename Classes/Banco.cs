using AppCaldeirasV2.Classes;
using MongoDB.Bson;
using MongoDB.Driver;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AppCaldeirasV2
{
    public class Banco
    {
        string connectionString = "mongodb://localhost:27017";
        string databaseName = "Caldeiras";
        string collectionName = "caldeiras";
        double pressao;
        double temperatura;
        double NivelAgua;
        double NivelCombustivel;
        string Status = "";
        DateTime Data;
        string Id = "";

       
        public List<string> BuscarUltimoStatusCaldeira(string NomeCaldeira)
        {
            List<string> listDados = new List<string>();


            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<BsonDocument>(collectionName);

            var filterBuilder = Builders<BsonDocument>.Filter;

            var filter = filterBuilder.Eq("NomeCaldeira", NomeCaldeira);

            var sort = Builders<BsonDocument>.Sort.Descending("Data"); // Ordena por _id em ordem decrescente
            var document = collection.Find(filter).Sort(sort).Limit(1).SingleOrDefault();


            foreach (var item in document)
            {
                pressao = document["Pressao"].AsDouble;
                temperatura = document["Temperatura"].AsDouble;
                NivelAgua = document["NivelAgua"].AsDouble;
                NivelCombustivel = document["NivelCombustivel"].AsDouble;
                Status = document["Status"].AsString;
                Data = document["Data"].AsDateTime;
                Id = document["_id"].AsString;
            }

            if (pressao.ToString().Length > 5)
            {
                pressao = double.Parse(pressao.ToString().Substring(0, 5));
            }
            if (temperatura.ToString().Length > 5)
            {
                temperatura = double.Parse(temperatura.ToString().Substring(0, 5));
            }
            if (NivelAgua.ToString().Length > 5)
            {
                NivelAgua = double.Parse(NivelAgua.ToString().Substring(0, 5));
            }
            if (NivelCombustivel.ToString().Length > 5)
            {
                NivelCombustivel = double.Parse(NivelCombustivel.ToString().Substring(0, 5));
            }


            listDados.Add(pressao.ToString());
            listDados.Add(temperatura.ToString());
            listDados.Add(NivelAgua.ToString());
            listDados.Add(NivelCombustivel.ToString());
            listDados.Add(Status.ToString());
            listDados.Add(Id.ToString());

            return listDados;
        }
        public List<string> BuscarUltimo100RegistrosPorIndicador(string NomeCaldeira,string TipoIndicador)
        {
            List<string> listDados = new List<string>();

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<BsonDocument>(collectionName);

            var filter = Builders<BsonDocument>.Filter.Eq("NomeCaldeira", NomeCaldeira); 
            var sort = Builders<BsonDocument>.Sort.Descending("Data");

            var documents = collection.Find(filter)
                                      .Sort(sort)
                                      .Limit(10)
                                      .ToList();

            foreach (var document in documents)
            {
                var Indicador = document[TipoIndicador].AsDouble;

                if (Indicador.ToString().Length > 5)
                {
                    Indicador = double.Parse(Indicador.ToString().Substring(0, 5));
                }

                listDados.Add(Indicador.ToString());
                
            }

          

            return listDados;
        }
        public List<string> BuscarMediaIndicadores(string NomeCaldeira)
        {
            List<string> listDados = new List<string>();

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<BsonDocument>(collectionName);

            var filterBuilder = Builders<BsonDocument>.Filter;

            var filter = filterBuilder.Eq("NomeCaldeira", NomeCaldeira);

            var aggregate = collection.Aggregate()
                .Match(filter)
             .Group(new BsonDocument
             {
                 { "_id", BsonNull.Value },
                { "mediaPressao", new BsonDocument("$avg", "$Pressao") },
                { "mediaTemperatura", new BsonDocument("$avg", "$Temperatura") },
                 { "mediaAgua", new BsonDocument("$avg", "$NivelAgua") },
                 { "mediaCombustivel", new BsonDocument("$avg", "$NivelCombustivel") }
             });

            var result = aggregate.FirstOrDefault();

            pressao = result["mediaPressao"].AsDouble;
            temperatura = result["mediaTemperatura"].AsDouble;
            NivelAgua = result["mediaAgua"].AsDouble;
            NivelCombustivel = result["mediaCombustivel"].AsDouble;

            if (pressao.ToString().Length > 5)
            {
                pressao = double.Parse(pressao.ToString().Substring(0,5));
            }
            if (temperatura.ToString().Length > 5)
            {
                temperatura = double.Parse(temperatura.ToString().Substring(0, 5));
            }
            if (NivelAgua.ToString().Length > 5)
            {
                NivelAgua = double.Parse(NivelAgua.ToString().Substring(0, 5));
            }
            if (NivelCombustivel.ToString().Length > 5)
            {
                NivelCombustivel = double.Parse(NivelCombustivel.ToString().Substring(0, 5));
            }

            listDados.Add(pressao.ToString());
            listDados.Add(temperatura.ToString());
            listDados.Add(NivelAgua.ToString());
            listDados.Add(NivelCombustivel.ToString());

            return listDados;
        }
        public void ExportarParaExcel(string NomeCaldeira)
        {
            Banco_Model banco_Model = new Banco_Model();
            // Conectar ao banco de dados do MongoDB
            var cliente = new MongoClient(connectionString);
            var database = cliente.GetDatabase(databaseName);
            var colecao = database.GetCollection<BsonDocument>(collectionName);

            // Obter os últimos 100 registros com o filtro
            var filtro = Builders<BsonDocument>.Filter.Eq("NomeCaldeira", NomeCaldeira);
            var opcoes = new FindOptions<BsonDocument>
            {
                Sort = Builders<BsonDocument>.Sort.Descending("Data"),
                Limit = 100
            };

            var dados = colecao.Find(filtro).ToList();

            // Criar um novo arquivo Excel
            var pacoteExcel = new ExcelPackage();

            // Criar uma planilha de trabalho
            var planilha = pacoteExcel.Workbook.Worksheets.Add("Planilha1");

            // Escrever os cabeçalhos
            planilha.Cells[1, 1].Value = "NomeCaldeira";
            planilha.Cells[1, 2].Value = "ID";
            planilha.Cells[1, 3].Value = "Pressao";
            planilha.Cells[1, 4].Value = "Temperatura";
            planilha.Cells[1, 5].Value = "NivelAgua";
            planilha.Cells[1, 6].Value = "NivelCombustivel";
            planilha.Cells[1, 7].Value = "Status";
            planilha.Cells[1, 8].Value = "Data";


            // Escrever os dados nas células
            int linha = 2;
            foreach (var item in dados)
            {
                planilha.Cells[linha, 1].Value = item[1].ToString();
                planilha.Cells[linha, 2].Value = item[0].ToString();
                planilha.Cells[linha, 3].Value = item[3].ToString();
                planilha.Cells[linha, 4].Value = item[6].ToString();
                planilha.Cells[linha, 5].Value = item[4].ToString();
                planilha.Cells[linha, 6].Value = item[5].ToString();
                planilha.Cells[linha, 7].Value = item[2].ToString();
                planilha.Cells[linha, 8].Value = item[7].ToString();
                // ...
                linha++;
            }

            // Salvar o arquivo Excel
            string MeusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string Data = DataSql(DateTime.Now.ToString());
            var nomeArquivo =  $"Exportacao_{Data}_{NomeCaldeira}.xls";
            var caminhoArquivo = Path.Combine(MeusDocumentos, nomeArquivo);
            FileInfo arquivoExcel = new FileInfo(caminhoArquivo);
            pacoteExcel.SaveAs(arquivoExcel);

            MessageBox.Show("Relatório da caldeira gerado com sucesso e enviado para a pasta 'Meus Documentos'.");

            //Process.Start(arquivoExcel.ToString());
        }
        private string  DataSql(string Texto)
        {
            Texto = Texto.Substring(0, 10);
            string dia = Texto.Split('/')[0];
            string mes = Texto.Split('/')[1];
            string anos = Texto.Split('/')[2];

            Texto = anos + "-" + mes + "-" + dia;
            return Texto;
        }

        public string InverterString(string input)
        {
            char[] caracteres = input.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}
