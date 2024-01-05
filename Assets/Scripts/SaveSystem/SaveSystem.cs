using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
    public static void SaveShip(Garagepannel shipdata)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/Shipdata.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        ShipData data = new ShipData(shipdata);

        formatter.Serialize(stream, data);
        stream.Close();          
    }

    public static ShipData LoadShip()
    {
        string path = Application.persistentDataPath + "/Shipdata.fun";

        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ShipData data = formatter.Deserialize(stream) as ShipData;
            return data;
        }
        else
        {
            Debug.Log("File not found in path" + path);
            return null;
        }
    }
}
