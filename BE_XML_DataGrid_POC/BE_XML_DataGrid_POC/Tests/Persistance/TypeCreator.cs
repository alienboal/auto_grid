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
 

using BE_XML_DataGrid_POC.ServiceReferenceDB;
using System.Reflection.Emit;
using System.Reflection;

using System.Threading;
using System.Collections.ObjectModel;
namespace BE_XML_DataGrid_POC.Persistance
{
    /// <summary>
    /// Create a new type of data
    /// </summary>
    public class TypeCreator
    {
        #region private members 
        private Type newClassType;
        #endregion

        #region properties  


        public Type NewClassType{ 
            get
            {
                return newClassType;
            }
            set
            {
            }
        }

        #endregion



        #region constructor
         /// <summary>
        /// Creates a new type
        /// </summary>
        /// <param name="listOfProperties">the properties of the new type</param>
        public TypeCreator(ObservableCollection<ColumnType> listOfProperties)
        {
            CreateNewType(listOfProperties);
        }
        #endregion


        #region methods
            
        /// <summary>
        /// Creates the new type 
        /// </summary>
        /// <param name="listOfProperties">dictionary of the properties and their types</param>
        private void CreateNewType(ObservableCollection<ColumnType> listOfProperties)
        {

            AssemblyName assemblyName = new AssemblyName();
            assemblyName.Name = "TableAssemblyClass";
            Type generetedType = null;
            // object AudioInObject = null;
            AssemblyBuilder assemblybuilder = Thread.GetDomain().DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
            ModuleBuilder module = assemblybuilder.DefineDynamicModule("TaleDetailsModule");
            TypeBuilder typebuilder = module.DefineType("TableType", TypeAttributes.Public | TypeAttributes.Class);
            try
            {
                foreach (ColumnType item in listOfProperties)
                {
                    AddProperty(typebuilder, item.Name, Type.GetType( item.Type) );

                }
                // Generate our type
                generetedType = typebuilder.CreateType();

                // Now we have our type. Let's create an instance from it:
                // AudioInObject = Activator.CreateInstance(generetedType);
                newClassType = generetedType;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            newClassType = generetedType;
        }
        
        /// <summary>
        /// Adds a new property o the runtime class
        /// </summary>
        /// <param name="typebuilder"></param>
        /// <param name="propertyName">name of the property</param>
        /// <param name="typeOfProperty">type of the property</param>
        private static void AddProperty(TypeBuilder typebuilder, string propertyName, Type typeOfProperty)
        {


            // Generate a private field
            FieldBuilder field = typebuilder.DefineField("_" + propertyName, typeOfProperty, FieldAttributes.Private);
            // Generate a public property
            PropertyBuilder property =
                typebuilder.DefineProperty(propertyName,
                                 PropertyAttributes.None,
                                 typeOfProperty,
                                 new Type[] { typeOfProperty });

            // The property set and property get methods require a special set of attributes:

            MethodAttributes GetSetAttr =
                MethodAttributes.Public |
                MethodAttributes.HideBySig;

            // Define the "get" accessor method for current private field.
            MethodBuilder currGetPropMthdBldr =
                typebuilder.DefineMethod("get_value",
                                           GetSetAttr,
                                           typeOfProperty,
                                           Type.EmptyTypes);

            // Intermediate Language stuff...
            ILGenerator currGetIL = currGetPropMthdBldr.GetILGenerator();
            currGetIL.Emit(OpCodes.Ldarg_0);
            currGetIL.Emit(OpCodes.Ldfld, field);
            currGetIL.Emit(OpCodes.Ret);

            // Define the "set" accessor method for current private field.
            MethodBuilder currSetPropMthdBldr =
                typebuilder.DefineMethod("set_value",
                                           GetSetAttr,
                                           null,
                                           new Type[] { typeOfProperty });

            // Again some Intermediate Language stuff...
            ILGenerator currSetIL = currSetPropMthdBldr.GetILGenerator();
            currSetIL.Emit(OpCodes.Ldarg_0);
            currSetIL.Emit(OpCodes.Ldarg_1);
            currSetIL.Emit(OpCodes.Stfld, field);
            currSetIL.Emit(OpCodes.Ret);

            // Last, we must map the two methods created above to our PropertyBuilder to
            // their corresponding behaviors, "get" and "set" respectively.
            property.SetGetMethod(currGetPropMthdBldr);
            property.SetSetMethod(currSetPropMthdBldr);
        }

        #endregion
    }
}
