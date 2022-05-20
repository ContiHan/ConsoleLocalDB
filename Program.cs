using ConsoleLocalDB;

SqlDataAccess dataAccess = new();
List<SqlData> dbData;

//dbData = dataAccess.GetAllSqlData();
//Console.WriteLine("Všechna data z DB");
//dbData.ForEach(data => Console.WriteLine(data.FullInfo));
//Console.WriteLine();

//Console.WriteLine("Data z DB, kde je Dan");
//dbData = dataAccess.GetSqlDataByName("Dan");
//dbData.ForEach(data => Console.WriteLine(data.FullInfo));

//dataAccess.AddToSqlDb("Karel", 100);
dbData = dataAccess.GetSqlDataByName("Karel");
dbData.ForEach(data => Console.WriteLine(data.FullInfo));