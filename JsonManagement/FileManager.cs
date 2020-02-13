using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonManagement
{
    public static class FileManager
    {
        public static string DefaultPath = Directory.GetCurrentDirectory();
        public static Types DefaultType = Types.Json;
        public static void Serialize(this object obj, Types type = Types.Json)
        {
            type = DefaultType != type ? DefaultType : type;
            switch (type)
            {
                case Types.Json:
                    {
                        JsonManager.Serialize(obj);
                        break;
                    }
                case Types.Yaml:
                    break;
                
            }

        }

        ///<summary> 
        ///Create a .json from an object. 
        ///</summary>  
        ///<param name="obj"> Object of any type. </param>
        ///<param name="name"> Just the name to save .json file. </param>
        public static void Serialize(this object obj, string name, Types type = Types.Json)
        {
            type = DefaultType != type ? DefaultType : type;
            switch (type)
            {
                case Types.Json:
                    {
                        JsonManager.Serialize(obj, name);
                        break;
                    }
                case Types.Yaml:
                    break;

            }

        }

        ///<summary> 
        ///Create a .json file from an object on a specific path. 
        ///</summary>  
        ///<param name="obj"> Object of any type. </param>
        ///<param name="path"> path without the name to save .json file. </param>        
        public static void SerializeIn(this object obj, string path, Types type = Types.Json)
        {
            type = DefaultType != type ? DefaultType : type;
            switch (type)
            {
                case Types.Json:
                    {
                        JsonManager.SerializeIn(obj, path);
                        break;
                    }
                case Types.Yaml:
                    break;

            }

        }

        ///<summary> 
        /// Create a .json file from an object on a specific path. 
        ///</summary>  
        ///<param name="obj"> Object of any type. </param>
        ///<param name="name"> Name to save .json file. </param>
        ///<param name="path"> path without the name to save .json file. </param>
        public static void SerializeIn(this object obj, string path, string name, Types type = Types.Json)
        {
            type = DefaultType != type ? DefaultType : type;
            switch (type)
            {
                case Types.Json:
                    {
                        JsonManager.SerializeIn(obj, path, name);
                        break;
                    }
                case Types.Yaml:
                    break;

            }

        }




        ///<summary> 
        /// Read a .json file and convert in a any object with empty constructor. 
        ///</summary> 
        ///<returns> An object with empty constructor from .Json file or an empty object. </returns>       
        public static T Deserialize<T>(Types type = Types.Json) where T : new()
        {
            type = DefaultType != type ? DefaultType : type;
            switch (type)
            {
                case Types.Json:
                    {
                        return JsonManager.Deserialize<T>();                        
                    }
                case Types.Yaml:
                    {
                        return JsonManager.Deserialize<T>();
                    }
                default:
                    {
                        return JsonManager.Deserialize<T>();
                    }
            }
           
        }

        ///<summary> 
        /// Read a .json file and convert in a any object with empty constructor.
        ///</summary> 
        ///<returns> An object with empty constructor from .Json file or an empty object. </returns>
        ///<param name="name"> Just the name of .json file. </param>
        public static T Deserialize<T>(string name, Types type = Types.Json) where T : new()
        {
            type = DefaultType != type ? DefaultType : type;
            switch (type)
            {
                case Types.Json:
                    {
                        return JsonManager.Deserialize<T>(name);
                    }
                case Types.Yaml:
                    {
                        return JsonManager.Deserialize<T>(name);
                    }
                default:
                    {
                        return JsonManager.Deserialize<T>(name);
                    }
            }
        }

        ///<summary> 
        /// Read a .json file and convert in a any object with empty constructor.
        ///</summary> 
        ///<returns> An object with empty constructor from .Json file or an empty object. </returns>
        ///<param name="path">  path without the name of .json file. </param>
        public static T DeserializeIn<T>(string path, Types type = Types.Json) where T : new()
        {
            type = DefaultType != type ? DefaultType : type;
            switch (type)
            {
                case Types.Json:
                    {
                        return JsonManager.DeserializeIn<T>(path);
                    }
                case Types.Yaml:
                    {
                        return JsonManager.DeserializeIn<T>(path);
                    }
                default:
                    {
                        return JsonManager.DeserializeIn<T>(path);
                    }
            }
        }

        ///<summary> 
        /// Read a .json file and convert in a any object with empty constructor 
        ///</summary> 
        ///<returns>An object with empty constructor from .Json file or an empty object. </returns>
        ///<param name="name"> Just the name of .json file. </param>
        ///<param name="path"> Instance of class FilePath with the path of .json file. </param>
        public static T DeserializeIn<T>(string path, string name,Types type = Types.Json) where T : new()
        {
            type = DefaultType != type ? DefaultType : type;
            switch (type)
            {
                case Types.Json:
                    {
                        return JsonManager.DeserializeIn<T>(path, name);
                    }
                case Types.Yaml:
                    {
                        return JsonManager.DeserializeIn<T>(path, name);
                    }
                default:
                    {
                        return JsonManager.DeserializeIn<T>(path, name);
                    }
            }

        }

        ///<summary> 
        /// Read a .json file and convert in a any object
        ///</summary> 
        ///<returns> An object from .json file or an empty object. </returns>     
        ///<param name="obj"> Object of any type. </param>
        public static T Deserialize<T>(this T obj, Types type = Types.Json)
        {
            type = DefaultType != type ? DefaultType : type;
            switch (type)
            {
                case Types.Json:
                    {
                        return JsonManager.Deserialize<T>(obj);
                    }
                case Types.Yaml:
                    {
                        return JsonManager.Deserialize<T>(obj);
                    }
                default:
                    {
                        return JsonManager.Deserialize<T>(obj);
                    }
            }

        }

        ///<summary> 
        /// Read a .json file and convert in a any object
        ///</summary> 
        ///<returns> An object from .json file or an empty object. </returns>
        ///<param name="name"> Just the name of .json file. </param>
        ///<param name="obj"> Object of any type. </param>
        public static T Deserialize<T>(this T obj, string name, Types type = Types.Json) where T : new()
        {
            type = DefaultType != type ? DefaultType : type;
            switch (type)
            {
                case Types.Json:
                    {
                        return JsonManager.Deserialize<T>(obj, name);
                    }
                case Types.Yaml:
                    {
                        return JsonManager.Deserialize<T>(obj, name);
                    }
                default:
                    {
                        return JsonManager.Deserialize<T>(obj, name);
                    }
            }

        }

        ///<summary> 
        /// Read a .json file and convert in a any object
        ///</summary> 
        ///<returns> An object from .json file or an empty object. </returns>
        ///<param name="name"> Just the name of .json file. </param>
        ///<param name="path"> path without the name of .json file. </param>
        ///<param name="obj"> Object of any type. </param>
        public static T DeserializeIn<T>(this T obj, string path, string name, Types type = Types.Json)
        {
            type = DefaultType != type ? DefaultType : type;
            switch (type)
            {
                case Types.Json:
                    {
                        return JsonManager.DeserializeIn<T>(obj, path, name);
                    }
                case Types.Yaml:
                    {
                        return JsonManager.DeserializeIn<T>(obj, path, name);
                    }
                default:
                    {
                        return JsonManager.DeserializeIn<T>(obj, path, name);
                    }
            }


        }

        ///<summary> 
        /// Read a .json file and convert in a any object
        ///</summary> 
        ///<returns> An object from .json file or an empty object. </returns>
        ///<param name="path"> path without the name of .json file. </param>
        ///<param name="obj"> Object of any type. </param>
        public static T DeserializeIn<T>(this T obj, string path, Types type = Types.Json)
        {
            type = DefaultType != type ? DefaultType : type;
            switch (type)
            {
                case Types.Json:
                    {
                        return JsonManager.DeserializeIn<T>(obj, path);
                    }
                case Types.Yaml:
                    {
                        return JsonManager.DeserializeIn<T>(obj, path);
                    }
                default:
                    {
                        return JsonManager.DeserializeIn<T>(obj, path);
                    }
            }
        }

    }
}
