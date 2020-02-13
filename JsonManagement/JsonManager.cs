using Newtonsoft.Json;
using System;
using System.IO;

namespace JsonManagement
{
    internal static class JsonManager
    {
        

        ///<summary> 
        ///Create a .json from an object. 
        ///</summary>  
        ///<param name="obj"> Object of any type. </param>
        internal static void Serialize (this object obj)
        {
            try
            {
                File.WriteAllText(GetPath(obj), JsonConvert.SerializeObject(obj));
            }
            catch (Exception)
            {
                throw;
            }

        }

        ///<summary> 
        ///Create a .json from an object. 
        ///</summary>  
        ///<param name="obj"> Object of any type. </param>
        ///<param name="name"> Just the name to save .json file. </param>
        internal static void Serialize(this object obj, string name)
        {
            try
            {
                File.WriteAllText(GetPath(name), JsonConvert.SerializeObject(obj));
            }
            catch (Exception)
            {
                throw;
            }

        }

        ///<summary> 
        ///Create a .json file from an object on a specific path. 
        ///</summary>  
        ///<param name="obj"> Object of any type. </param>
        ///<param name="path"> path without the name to save .json file. </param>        
        internal static void SerializeIn(this object obj, string path)
        {
            try
            {
                File.WriteAllText(GetPath(obj, path), JsonConvert.SerializeObject(obj));
            }
            catch (Exception)
            {
                throw;
            }

        }

        ///<summary> 
        /// Create a .json file from an object on a specific path. 
        ///</summary>  
        ///<param name="obj"> Object of any type. </param>
        ///<param name="name"> Name to save .json file. </param>
        ///<param name="path"> path without the name to save .json file. </param>
        internal static void SerializeIn(this object obj, string path, string name)
        {
            try
            {
                File.WriteAllText(GetPath(name, path), JsonConvert.SerializeObject(obj));
            }
            catch (Exception)
            {
                throw;
            }

        }




        ///<summary> 
        /// Read a .json file and convert in a any object with empty constructor. 
        ///</summary> 
        ///<returns> An object with empty constructor from .Json file or an empty object. </returns>       
        internal static T Deserialize<T>() where T : new()
        {
            string path = GetPath(typeof(T).Name);
            if (!File.Exists(path))
            {
                T vari = new T();
                return vari;
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
            }




        }

        ///<summary> 
        /// Read a .json file and convert in a any object with empty constructor.
        ///</summary> 
        ///<returns> An object with empty constructor from .Json file or an empty object. </returns>
        ///<param name="name"> Just the name of .json file. </param>
        internal static T Deserialize<T>(string name) where T : new()
        {
            string path = GetPath(name);
            if (!File.Exists(path))
            {
                T vari = new T();
                return vari;
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
            }
        }

        ///<summary> 
        /// Read a .json file and convert in a any object with empty constructor.
        ///</summary> 
        ///<returns> An object with empty constructor from .Json file or an empty object. </returns>
        ///<param name="path">  path without the name of .json file. </param>
        internal static T DeserializeIn<T>(string path) where T : new()
        {
            string route = GetPath(typeof(T).Name, path);
            if (!File.Exists(route))
            {
                T vari = new T();
                return vari;
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(route));
            }
        }

        ///<summary> 
        /// Read a .json file and convert in a any object with empty constructor 
        ///</summary> 
        ///<returns>An object with empty constructor from .Json file or an empty object. </returns>
        ///<param name="name"> Just the name of .json file. </param>
        ///<param name="path"> Instance of class FilePath with the path of .json file. </param>
<<<<<<< HEAD
        public static T DeserializeIn<T>(string path, string name) where T : new()
=======
        internal static T DeserializeIn<T>(string path, string name) where T : new()
>>>>>>> f54347e1369427060502026f2f989ae152096044
        {
            var route = GetPath(name, path);
            if (!File.Exists(route))
            {
                T vari = new T();
                return vari;
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(route));
            }

        }

        ///<summary> 
        /// Read a .json file and convert in a any object
        ///</summary> 
        ///<returns> An object from .json file or an empty object. </returns>     
        ///<param name="obj"> Object of any type. </param>
        internal static T Deserialize<T>(this T obj)
        {
            string path = GetPath(typeof(T).Name);
            if (!File.Exists(path))
            {
                return obj;
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
            }




        }

        ///<summary> 
        /// Read a .json file and convert in a any object
        ///</summary> 
        ///<returns> An object from .json file or an empty object. </returns>
        ///<param name="name"> Just the name of .json file. </param>
        ///<param name="obj"> Object of any type. </param>
<<<<<<< HEAD
        public static T Deserialize<T>(this T obj, string name)
=======
        internal static T Deserialize<T>(this T obj, string name) where T : new()
>>>>>>> f54347e1369427060502026f2f989ae152096044
        {
            string path = GetPath(name);
            if (!File.Exists(path))
            {
                return obj;
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
            }
        }

        ///<summary> 
        /// Read a .json file and convert in a any object
        ///</summary> 
        ///<returns> An object from .json file or an empty object. </returns>
        ///<param name="name"> Just the name of .json file. </param>
        ///<param name="path"> path without the name of .json file. </param>
        ///<param name="obj"> Object of any type. </param>
        public static T DeserializeIn<T>(this T obj, string path, string name)
        {
            var route = GetPath(name, path);
            if (!File.Exists(route))
            {
                return obj;
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(route));
            }

        }

        ///<summary> 
        /// Read a .json file and convert in a any object
        ///</summary> 
        ///<returns> An object from .json file or an empty object. </returns>
        ///<param name="path"> path without the name of .json file. </param>
        ///<param name="obj"> Object of any type. </param>
<<<<<<< HEAD
        public static T DeserializeIn<T>(this T obj, string path)
=======
        internal static T DeserializeIn<T>(this T obj, string path)
>>>>>>> f54347e1369427060502026f2f989ae152096044
        {
            string route = GetPath(typeof(T).Name, path);
            if (!File.Exists(route))
            {
                return obj;
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(route));
            }
        }

        private static string GetPath(object obj)
        {
            return FileManager.DefaultPath + "\\" + obj.GetType().Name + ".json";
        }
        private static string GetPath(object obj, string path)
        {
            return path + "\\" + obj.GetType().Name + ".json";
        }


        private static string GetPath(string name)
        {
            return FileManager.DefaultPath + "\\" + name + ".json";
        }
        private static string GetPath(string name, string path)
        {
            return path + "\\" + name + ".json";
        }

    }

}