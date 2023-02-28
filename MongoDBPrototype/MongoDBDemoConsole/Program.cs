using MongoDataAccess.DataAccess;
using MongoDataAccess.Models;
using MongoDB.Driver;
using MongoDBPrototype;


//string connectionString = "mongodb://localhost:27017";
//string databaseName = "simple_db";
//string collectionName = "people";

//var client = new MongoClient(connectionString);
//var db = client.GetDatabase(databaseName);
//var collection = db.GetCollection<PersonModel>(collectionName);

//var person = new PersonModel { FirstName = "Simple", LastName = "Sketche" };

//await collection.InsertOneAsync(person);

//var results = await collection.FindAsync(_ => true);

//foreach(var result in results.ToList())
//{
//    Console.WriteLine($"{result.Id}: First name: {result.FirstName}. Last name: {result.LastName}");
//}

ChoreDataAccess db = new ChoreDataAccess();

await db.CreateUser(new UserModel()
{
    FirstName = "Simple",
    LastName = "Sketche"
});

var users = await db.GetAllUsers();

var chore = new ChoreModel() { AssignedTo = users.First(), ChoreText = "Pick up trash!", FrequencyInDays= 1 };

await db.CreateChore(chore);