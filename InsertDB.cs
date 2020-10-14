using MongoDB.Bson;
using MongoDB.Driver;
public class InsertDB
{

    public void Insert(MongoClient client, string dbName)
    {
        var document = new BsonDocument { { "student_id", 10000 }, {
            "scores",
                new BsonArray {
                new BsonDocument { { "type", "exam" }, { "score", 88.12334193287023 } },
                new BsonDocument { { "type", "quiz" }, { "score", 74.92381029342834 } },
                new BsonDocument { { "type", "homework" }, { "score", 89.97929384290324 } },
                new BsonDocument { { "type", "homework" }, { "score", 82.12931030513218 } }
                }
            }, { "class_id", 480 }
        };
         var database = client.GetDatabase(dbName);
         database.CreateCollection("grades",null);
         var collection = database.GetCollection<BsonDocument> ("grades");
         collection.InsertOne(document);
    }
}