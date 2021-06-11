//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 08.03.2021 23:09:34
namespace Namespace.Foo
{
    /// <summary>
    /// There are no comments for BaseTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("baseTypeSingle")]
    public partial class BaseTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BaseType>
    {
        /// <summary>
        /// Initialize a new BaseTypeSingle object.
        /// </summary>
        public BaseTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) { }

        /// <summary>
        /// Initialize a new BaseTypeSingle object.
        /// </summary>
        public BaseTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) { }

        /// <summary>
        /// Initialize a new BaseTypeSingle object.
        /// </summary>
        public BaseTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BaseType> query)
            : base(query) { }

    }
    /// <summary>
    /// There are no comments for BaseType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// KeyProp
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("keyProp")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("baseType")]
    public partial class BaseType : global::Microsoft.OData.Client.BaseEntityType
    {
        /// <summary>
        /// Create a new BaseType object.
        /// </summary>
        /// <param name="keyProp">Initial value of KeyProp.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static BaseType CreateBaseType(int keyProp)
        {
            BaseType baseType = new BaseType();
            baseType.KeyProp = keyProp;
            return baseType;
        }
        /// <summary>
        /// There are no comments for Property KeyProp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("keyProp")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "KeyProp is required.")]
        public virtual int KeyProp
        {
            get
            {
                return this._KeyProp;
            }
            set
            {
                this.OnKeyPropChanging(value);
                this._KeyProp = value;
                this.OnKeyPropChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _KeyProp;
        partial void OnKeyPropChanging(int value);
        partial void OnKeyPropChanged();
    }
    /// <summary>
    /// There are no comments for TestTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("testTypeSingle")]
    public partial class TestTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TestType>
    {
        /// <summary>
        /// Initialize a new TestTypeSingle object.
        /// </summary>
        public TestTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) { }

        /// <summary>
        /// Initialize a new TestTypeSingle object.
        /// </summary>
        public TestTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) { }

        /// <summary>
        /// Initialize a new TestTypeSingle object.
        /// </summary>
        public TestTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TestType> query)
            : base(query) { }

        /// <summary>
        /// There are no comments for SingleType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("singleType")]
        public virtual global::Namespace.Foo.SingleTypeSingle SingleType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SingleType == null))
                {
                    this._SingleType = new global::Namespace.Foo.SingleTypeSingle(this.Context, GetPath("singleType"));
                }
                return this._SingleType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Namespace.Foo.SingleTypeSingle _SingleType;
    }
    /// <summary>
    /// There are no comments for TestType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// KeyProp
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("keyProp")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("testType")]
    public partial class TestType : BaseType
    {
        /// <summary>
        /// Create a new TestType object.
        /// </summary>
        /// <param name="keyProp">Initial value of KeyProp.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static TestType CreateTestType(int keyProp)
        {
            TestType testType = new TestType();
            testType.KeyProp = keyProp;
            return testType;
        }
        /// <summary>
        /// There are no comments for Property SingleType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("singleType")]
        public virtual global::Namespace.Foo.SingleType SingleType
        {
            get
            {
                return this._SingleType;
            }
            set
            {
                this.OnSingleTypeChanging(value);
                this._SingleType = value;
                this.OnSingleTypeChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Namespace.Foo.SingleType _SingleType;
        partial void OnSingleTypeChanging(global::Namespace.Foo.SingleType value);
        partial void OnSingleTypeChanged();
    }
    /// <summary>
    /// There are no comments for SingleTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("singleTypeSingle")]
    public partial class SingleTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SingleType>
    {
        /// <summary>
        /// Initialize a new SingleTypeSingle object.
        /// </summary>
        public SingleTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) { }

        /// <summary>
        /// Initialize a new SingleTypeSingle object.
        /// </summary>
        public SingleTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) { }

        /// <summary>
        /// Initialize a new SingleTypeSingle object.
        /// </summary>
        public SingleTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SingleType> query)
            : base(query) { }

        /// <summary>
        /// There are no comments for BaseSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("baseSet")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Namespace.Foo.TestType> BaseSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BaseSet == null))
                {
                    this._BaseSet = Context.CreateQuery<global::Namespace.Foo.TestType>(GetPath("baseSet"));
                }
                return this._BaseSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Namespace.Foo.TestType> _BaseSet;
    }
    /// <summary>
    /// There are no comments for SingleType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// KeyProp
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("keyProp")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("singleType")]
    public partial class SingleType : global::Microsoft.OData.Client.BaseEntityType
    {
        /// <summary>
        /// Create a new SingleType object.
        /// </summary>
        /// <param name="keyProp">Initial value of KeyProp.</param>
        /// <param name="colorProp">Initial value of ColorProp.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static SingleType CreateSingleType(int keyProp, global::Namespace.Foo.Color colorProp)
        {
            SingleType singleType = new SingleType();
            singleType.KeyProp = keyProp;
            singleType.ColorProp = colorProp;
            return singleType;
        }
        /// <summary>
        /// There are no comments for Property KeyProp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("keyProp")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "KeyProp is required.")]
        public virtual int KeyProp
        {
            get
            {
                return this._KeyProp;
            }
            set
            {
                this.OnKeyPropChanging(value);
                this._KeyProp = value;
                this.OnKeyPropChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _KeyProp;
        partial void OnKeyPropChanging(int value);
        partial void OnKeyPropChanged();
        /// <summary>
        /// There are no comments for Property ColorProp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("colorProp")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ColorProp is required.")]
        public virtual global::Namespace.Foo.Color ColorProp
        {
            get
            {
                return this._ColorProp;
            }
            set
            {
                this.OnColorPropChanging(value);
                this._ColorProp = value;
                this.OnColorPropChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Namespace.Foo.Color _ColorProp;
        partial void OnColorPropChanging(global::Namespace.Foo.Color value);
        partial void OnColorPropChanged();
        /// <summary>
        /// There are no comments for Property BaseSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("baseSet")]
        public virtual global::System.Collections.ObjectModel.Collection<global::Namespace.Foo.TestType> BaseSet
        {
            get
            {
                return this._BaseSet;
            }
            set
            {
                this.OnBaseSetChanging(value);
                this._BaseSet = value;
                this.OnBaseSetChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Collections.ObjectModel.Collection<global::Namespace.Foo.TestType> _BaseSet = new global::System.Collections.ObjectModel.Collection<global::Namespace.Foo.TestType>();
        partial void OnBaseSetChanging(global::System.Collections.ObjectModel.Collection<global::Namespace.Foo.TestType> value);
        partial void OnBaseSetChanged();
        /// <summary>
        /// There are no comments for Foo7 in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("foo7")]
        public virtual global::Microsoft.OData.Client.DataServiceActionQuerySingle<global::System.Nullable<int>> Foo7()
        {
            global::Microsoft.OData.Client.EntityDescriptor resource = Context.EntityTracker.TryGetEntityDescriptor(this);
            if (resource == null)
            {
                throw new global::System.Exception("cannot find entity");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuerySingle<global::System.Nullable<int>>(this.Context, resource.EditLink.OriginalString.Trim('/') + "/namespace.foo.foo7");
        }
    }
    /// <summary>
    /// There are no comments for Color in the schema.
    /// </summary>
    [global::System.Flags]
    [global::Microsoft.OData.Client.OriginalNameAttribute("color")]
    public enum Color
    {
        [global::Microsoft.OData.Client.OriginalNameAttribute("red")]
        Red = 0,
        [global::Microsoft.OData.Client.OriginalNameAttribute("white")]
        White = 1,
        [global::Microsoft.OData.Client.OriginalNameAttribute("blue")]
        Blue = 2
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::Namespace.Foo.BaseType as global::Namespace.Foo.BaseTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="_keys">dictionary with the names and values of keys</param>
        public static global::Namespace.Foo.BaseTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Namespace.Foo.BaseType> _source, global::System.Collections.Generic.IDictionary<string, object> _keys)
        {
            return new global::Namespace.Foo.BaseTypeSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::Namespace.Foo.BaseType as global::Namespace.Foo.BaseTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="keyProp">The value of keyProp</param>
        public static global::Namespace.Foo.BaseTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Namespace.Foo.BaseType> _source,
            int keyProp)
        {
            global::System.Collections.Generic.IDictionary<string, object> _keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "keyProp", keyProp }
            };
            return new global::Namespace.Foo.BaseTypeSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::Namespace.Foo.TestType as global::Namespace.Foo.TestTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="_keys">dictionary with the names and values of keys</param>
        public static global::Namespace.Foo.TestTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Namespace.Foo.TestType> _source, global::System.Collections.Generic.IDictionary<string, object> _keys)
        {
            return new global::Namespace.Foo.TestTypeSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::Namespace.Foo.TestType as global::Namespace.Foo.TestTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="keyProp">The value of keyProp</param>
        public static global::Namespace.Foo.TestTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Namespace.Foo.TestType> _source,
            int keyProp)
        {
            global::System.Collections.Generic.IDictionary<string, object> _keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "keyProp", keyProp }
            };
            return new global::Namespace.Foo.TestTypeSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Namespace.Foo.BaseType to its derived type global::Namespace.Foo.TestType
        /// </summary>
        /// <param name="_source">source entity</param>
        public static global::Namespace.Foo.TestTypeSingle CastToTestType(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Namespace.Foo.BaseType> _source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Namespace.Foo.TestType> query = _source.CastTo<global::Namespace.Foo.TestType>();
            return new global::Namespace.Foo.TestTypeSingle(_source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Get an entity of type global::Namespace.Foo.SingleType as global::Namespace.Foo.SingleTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="_keys">dictionary with the names and values of keys</param>
        public static global::Namespace.Foo.SingleTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Namespace.Foo.SingleType> _source, global::System.Collections.Generic.IDictionary<string, object> _keys)
        {
            return new global::Namespace.Foo.SingleTypeSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::Namespace.Foo.SingleType as global::Namespace.Foo.SingleTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="keyProp">The value of keyProp</param>
        public static global::Namespace.Foo.SingleTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Namespace.Foo.SingleType> _source,
            int keyProp)
        {
            global::System.Collections.Generic.IDictionary<string, object> _keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "keyProp", keyProp }
            };
            return new global::Namespace.Foo.SingleTypeSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// There are no comments for Foo7 in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("foo7")]
        public static global::Microsoft.OData.Client.DataServiceActionQuerySingle<global::System.Nullable<int>> Foo7(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Namespace.Foo.SingleType> _source)
        {
            if (!_source.IsComposable)
            {
                throw new global::System.NotSupportedException("The previous function is not composable.");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuerySingle<global::System.Nullable<int>>(_source.Context, _source.AppendRequestUri("namespace.foo.foo7"));
        }
    }
}
namespace Namespace.Bar
{
    /// <summary>
    /// There are no comments for SingletonContainer in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("singletonContainer")]
    public partial class SingletonContainer : global::Microsoft.OData.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new SingletonContainer object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public SingletonContainer(global::System.Uri serviceRoot) :
                base(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "namespace.bar", "Namespace.Bar");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            resolvedType = this.DefaultResolveType(typeName, "namespace.foo", "Namespace.Foo");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            global::Microsoft.OData.Client.OriginalNameAttribute originalNameAttribute = (global::Microsoft.OData.Client.OriginalNameAttribute)global::System.Linq.Enumerable.SingleOrDefault(global::Microsoft.OData.Client.Utility.GetCustomAttributes(clientType, typeof(global::Microsoft.OData.Client.OriginalNameAttribute), true));
            if (clientType.Namespace.Equals("Namespace.Bar", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("namespace.bar.", originalNameAttribute.OriginalName);
                }
                return string.Concat("namespace.bar.", clientType.Name);
            }
            if (clientType.Namespace.Equals("Namespace.Foo", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("namespace.foo.", originalNameAttribute.OriginalName);
                }
                return string.Concat("namespace.foo.", clientType.Name);
            }
            if (originalNameAttribute != null)
            {
                return clientType.Namespace + "." + originalNameAttribute.OriginalName;
            }
            return clientType.FullName;
        }
        /// <summary>
        /// There are no comments for TestTypeSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("testTypeSet")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Namespace.Foo.TestType> TestTypeSet
        {
            get
            {
                if ((this._TestTypeSet == null))
                {
                    this._TestTypeSet = base.CreateQuery<global::Namespace.Foo.TestType>("testTypeSet");
                }
                return this._TestTypeSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Namespace.Foo.TestType> _TestTypeSet;
        /// <summary>
        /// There are no comments for BaseTypeSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("baseTypeSet")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Namespace.Foo.BaseType> BaseTypeSet
        {
            get
            {
                if ((this._BaseTypeSet == null))
                {
                    this._BaseTypeSet = base.CreateQuery<global::Namespace.Foo.BaseType>("baseTypeSet");
                }
                return this._BaseTypeSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Namespace.Foo.BaseType> _BaseTypeSet;
        /// <summary>
        /// There are no comments for TestTypeSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public virtual void AddToTestTypeSet(global::Namespace.Foo.TestType testType)
        {
            base.AddObject("testTypeSet", testType);
        }
        /// <summary>
        /// There are no comments for BaseTypeSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public virtual void AddToBaseTypeSet(global::Namespace.Foo.BaseType baseType)
        {
            base.AddObject("baseTypeSet", baseType);
        }
        /// <summary>
        /// There are no comments for SuperType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("superType")]
        public virtual global::Namespace.Foo.TestTypeSingle SuperType
        {
            get
            {
                if ((this._SuperType == null))
                {
                    this._SuperType = new global::Namespace.Foo.TestTypeSingle(this, "superType");
                }
                return this._SuperType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Namespace.Foo.TestTypeSingle _SuperType;
        /// <summary>
        /// There are no comments for Single in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("single")]
        public virtual global::Namespace.Foo.SingleTypeSingle Single
        {
            get
            {
                if ((this._Single == null))
                {
                    this._Single = new global::Namespace.Foo.SingleTypeSingle(this, "single");
                }
                return this._Single;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Namespace.Foo.SingleTypeSingle _Single;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private const string Edmx = @"<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""namespace.foo"" xmlns:d=""http://docs.oasis-open.org/odata/ns/data"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""baseType"">
        <Key>
          <PropertyRef Name=""keyProp"" />
        </Key>
        <Property Name=""keyProp"" Type=""Edm.Int32"" Nullable=""false"" />
      </EntityType>
      <EntityType Name=""testType"" BaseType=""namespace.foo.baseType"">
        <NavigationProperty Name=""singleType"" Type=""namespace.foo.singleType"" />
      </EntityType>
      <EntityType Name=""singleType"">
        <Key>
          <PropertyRef Name=""keyProp"" />
        </Key>
        <Property Name=""keyProp"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""colorProp"" Type=""namespace.foo.color"" Nullable=""false"" />
        <NavigationProperty Name=""baseSet"" Type=""Collection(namespace.foo.testType)"" />
      </EntityType>
      <EnumType Name=""color"" UnderlyingType=""Edm.Int32"" IsFlags=""true"">
        <Member Name=""red"" />
        <Member Name=""white"" />
        <Member Name=""blue"" />
      </EnumType>
      <Function Name=""foo6"">
        <Parameter Name=""p1"" Type=""Collection(namespace.foo.testType)"" />
        <ReturnType Type=""Edm.String"" />
      </Function>
      <Action Name=""foo7"" IsBound=""True"">
        <Parameter Name=""p1"" Type=""namespace.foo.singleType"" />
        <ReturnType Type=""Edm.Int32"" />
      </Action>
    </Schema>
    <Schema Namespace=""namespace.bar"" xmlns:d=""http://docs.oasis-open.org/odata/ns/data"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityContainer Name=""singletonContainer"">
        <EntitySet Name=""testTypeSet"" EntityType=""namespace.foo.testType"" />
        <EntitySet Name=""baseTypeSet"" EntityType=""namespace.foo.baseType"" />
        <Singleton Name=""superType"" Type=""namespace.foo.testType"" />
        <Singleton Name=""single"" Type=""namespace.foo.singleType"" />
        <FunctionImport Name=""foo6"" Function=""namespace.foo.foo6"" />
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()
            {
                global::System.Xml.XmlReader reader = CreateXmlReader(Edmx);
                try
                {
                    global::System.Collections.Generic.IEnumerable<global::Microsoft.OData.Edm.Validation.EdmError> errors;
                    global::Microsoft.OData.Edm.IEdmModel edmModel;

                    if (!global::Microsoft.OData.Edm.Csdl.CsdlReader.TryParse(reader, false, out edmModel, out errors))
                    {
                        global::System.Text.StringBuilder errorMessages = new global::System.Text.StringBuilder();
                        foreach (var error in errors)
                        {
                            errorMessages.Append(error.ErrorMessage);
                            errorMessages.Append("; ");
                        }
                        throw new global::System.InvalidOperationException(errorMessages.ToString());
                    }

                    return edmModel;
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }

        }
        /// <summary>
        /// There are no comments for Foo6 in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("foo6")]
        public virtual global::Microsoft.OData.Client.DataServiceQuerySingle<string> Foo6(global::System.Collections.Generic.ICollection<global::Namespace.Foo.TestType> p1, bool useEntityReference = false)
        {
            return this.CreateFunctionQuerySingle<string>("", "foo6", false, new global::Microsoft.OData.Client.UriEntityOperationParameter("p1", p1, useEntityReference));
        }
    }
}
