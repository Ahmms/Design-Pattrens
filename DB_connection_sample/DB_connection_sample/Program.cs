using MongoDB.Driver;
using MongoDB.Bson;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//mongodb+srv://ahmad:<password>@cluster0.d0xqt.mongodb.net/?retryWrites=true&w=majority
//Passing the connection string in MongoClient  
var client = new MongoClient("mongodb+srv://ahmad:K26BnOx7KXJvFo97@cluster0.d0xqt.mongodb.net/?retryWrites=true&w=majority");
//Get sample_mflix Database  
var db = client.GetDatabase("Project");
//Get movies collection  
var collection = db.GetCollection<BsonDocument>("Project");
//Find document with title Peter Pan  
var result = collection.Find("{Brand:'Del'}").FirstOrDefault();
if(result == null)
{
    Console.WriteLine("a");
}
Console.WriteLine(result);
/*var Collec = db.GetCollection<BsonDocument>("Project");
var documnt = new BsonDocument
{
    {"Brand","Dell"},
    {"Price","400"},
    {"Ram","8GB"},
    {"HardDisk","1TB"},
    {"Screen","16inch"}
};
await Collec.InsertOneAsync(documnt);*/