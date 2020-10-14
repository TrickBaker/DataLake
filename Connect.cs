using MongoDB.Driver;

public static class Connection {

    public static MongoClient Connecting() {
        return new MongoClient("mongodb://127.0.0.1:27017/?compressors=disabled&gssapiServiceName=mongodb");
    }

    public static string dbName = "myshinynewdb";
}