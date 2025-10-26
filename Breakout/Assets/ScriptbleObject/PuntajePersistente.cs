using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class PuntajePersistente : ScriptableObject
{
    public void Guardar(string NombreArchivo = null)
    {
        var bf = new BinaryFormatter();
        var ruta = ObtenerRuta(NombreArchivo);
        var file = File.Create(ruta);
        var json = JsonUtility.ToJson(this);

        bf.Serialize(file, json);
        file.Close();
    }

    public void Cargar(string NombreArchivo = null)
    {
        var ruta = ObtenerRuta(NombreArchivo);

        if (!File.Exists(ruta))
        {
            Debug.LogWarning("Archivo no existe en: " + ruta);
            return;
        }

        var bf = new BinaryFormatter();
        var archivo = File.Open(ruta, FileMode.Open);
        JsonUtility.FromJsonOverwrite((string)bf.Deserialize(archivo), this);
        archivo.Close();
    }

    public string ObtenerRuta(string NombreArchivo = null)
    {
        var nombreArchivoCompleto = string.IsNullOrEmpty(NombreArchivo) ? name : NombreArchivo;
        return string.Format("{0}/{1}.dat", Application.persistentDataPath, nombreArchivoCompleto);
    }
}
