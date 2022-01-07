using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializerUtil
{
    public class Serializer<E>
    {
        
        public string Path;
        public Serializer(string Path)
        {
            this.Path = Path;
        }
        public E DeSerializer(){
            try
            {
                E OutObject = (E)(new object());
                BinaryFormatter BinFor = new BinaryFormatter();
                Stream stream;
                if (File.Exists("Settings.data"))
                {
                    stream = new FileStream(Path, FileMode.Open, FileAccess.Read);
                    if (stream.Length <= 0)
                        return OutObject;
                    OutObject = (E)BinFor.Deserialize(stream);
                    stream.Close();
                }
                return OutObject;
            }
            catch (IOException IOE)
            {
                throw IOE;
            }
        }
        public bool Serialize(E SaveObject)
        {
            try
            {
                BinaryFormatter BinFor = new BinaryFormatter();
                Stream stream;
                stream = new FileStream(Path, FileMode.Create, FileAccess.Write);
                BinFor.Serialize(stream,SaveObject);
                stream.Close();
                return true;
            }
            catch (IOException IOE)
            {
                throw IOE;
            }
        }
    }
}
