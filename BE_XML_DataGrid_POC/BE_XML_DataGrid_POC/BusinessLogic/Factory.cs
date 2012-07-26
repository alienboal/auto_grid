using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using BE_XML_DataGrid_POC.ServiceReferenceDB;
using BE_XML_DataGrid_POC.Persistance;
using System.Reflection;

namespace BE_XML_DataGrid_POC.BusinessLogic
{
    public class Factory
    {

        #region singleton


        private static volatile Factory singleton = null;
        private static object obj = new Object();



        public static Factory GetInstance(List<ColumnType> listOfProperties)
        {
            if (singleton == null)
            {
                lock (obj)
                {
                    if (singleton == null)
                    {
                        singleton = new Factory(listOfProperties);
                    }
                }

            }
            return singleton;

        }

        private Factory(List<ColumnType> listOfProperties)
        {
            runtimeType = new TypeCreator(listOfProperties);
        }

        #endregion


        #region private methods
         
        TypeCreator runtimeType;

        #endregion


        #region methods

        /// <summary>
        /// Creates and object at runtime
        /// </summary>
        /// <returns>the newly created object</returns>
        public object CreateObjectOfRType()
        {
            object instance = null;
            ConstructorInfo ctor = runtimeType.NewClassType.GetConstructor(System.Type.EmptyTypes);         //gets the main constructor of the type
            if (ctor != null)
            {
                instance = ctor.Invoke(null);
            }


            return instance;
        }


        /// <summary>
        /// Set the property of a runtime object
        /// </summary>
        /// <param name="instance">the runtme object</param>
        /// <param name="name">name of property</param>
        /// <param name="value">value of property</param>
        public void SetProperty(object instance, string name, object value)
        {
            runtimeType.NewClassType.GetProperty(name).SetValue(instance, value, null);
        }


        ////////////////////////////////LIST METHODS////////////////////////////////////////////////////////



        /// <summary>
        /// Creats a generic list at runtime
        /// </summary>
        /// <returns>the newly created list</returns>
        public Object CreateListOfRType()
        {
            Type listType = typeof(List<>);
            Type[] typeArgs = { runtimeType.NewClassType };
            Type genericType = listType.MakeGenericType(typeArgs);
            object o = Activator.CreateInstance(genericType);
            return o;
        }
        /// <summary>
        /// Adds a runtime created object to the object list
        /// </summary>
        /// <param name="objList">the list reference</param>
        /// <param name="newItem">the object to be added</param>
        public void AddToList(object objList, object newItem)
        {
            //Obtain method info to the Add method of our generic list
            MethodInfo mListAdd = objList.GetType().GetMethod("Add");

            //Add it to the list objList
            mListAdd.Invoke(objList, new object[] { newItem });
        }
       
        #endregion

    }
}
