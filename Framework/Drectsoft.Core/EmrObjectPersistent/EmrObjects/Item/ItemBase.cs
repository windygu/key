using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Globalization;

namespace DrectSoft.Common.Eop
{
   /// <summary>
   /// 医嘱项目基类,表示一个具体的医嘱项目,包括项目的基本属性、使用范围及其它特殊标记
   /// </summary>
   public abstract class ItemBase : EPBaseObject
   {
      #region properties
      /// <summary>
      /// 主键的值
      /// </summary>
      public virtual string KeyValue
      {
         get { return Code; }
      }

      /// <summary>
      /// 规格
      /// </summary>
      public string Specification
      {
         get { return _specification; }
         set { _specification = value; }
      }
      private string _specification;

      /// <summary>
      /// 零售价
      /// </summary>
      public Decimal RetailPrice
      {
         get { return _retailPrice; }
         set { _retailPrice = value; }
      }
      private Decimal _retailPrice;

      /// <summary>
      /// 单价(含单位)
      /// </summary>
      public virtual string Price
      {
         get
         { 
            return String.Format(CultureInfo.CurrentCulture
               , "{0:F}元/{1}", RetailPrice, BaseUnit.Name); 
         }
      }

      /// <summary>
      /// 基础单位(最小单位)
      /// </summary>
      public ItemUnit BaseUnit
      {
         get { return _baseUnit; }
         set { _baseUnit = value; }
      }
      private ItemUnit _baseUnit;

      //[Description("所属分类(所属大项目)")]
      //public CodeName Catalog
      //{
      //   get { return _catalog; }
      //   set { _catalog = value; }
      //}
      //private CodeName _catalog;

      /// <summary>
      /// 项目类别
      /// </summary>
      public ItemKind Kind
      {
         get { return _kind; }
         set { _kind = value; }
      }
      private ItemKind _kind;

      /// <summary>
      /// 门诊报销标志
      /// </summary>
      public SubmitAccountKind OutpatientSubmitFlag
      {
         get { return _outpatientSubmitFlag; }
         set { _outpatientSubmitFlag = value; }
      }
      private SubmitAccountKind _outpatientSubmitFlag;

      /// <summary>
      /// 住院报销标志
      /// </summary>
      public SubmitAccountKind InpatientSubmitFlag
      {
         get { return _inpatientSubmitFlag; }
         set { _inpatientSubmitFlag = value; }
      }
      private SubmitAccountKind _inpatientSubmitFlag;

      /// <summary>
      /// 项目使用范围标志
      /// </summary>
      public ItemApplyRange ItemApplyFlag
      {
         get { return _itemApplyFlag; }
         set { _itemApplyFlag = value; }
      }
      private ItemApplyRange _itemApplyFlag;

      /// <summary>
      /// 医嘱管理标志
      /// </summary>
      public OrderManagerKind OrderManagerFlag
      {
         get { return _orderManagerFlag; }
         set { _orderManagerFlag = value; }
      }
      private OrderManagerKind _orderManagerFlag;

      /// <summary>
      /// 系统标志
      /// </summary>
      public SystemApplyRange SystemFlag
      {
         get { return _systemFlag; }
         set { _systemFlag = value; }
      }
      private SystemApplyRange _systemFlag;

      #endregion

      #region ctor
      /// <summary>
      /// 
      /// </summary>
      protected ItemBase()
         : base()
      { }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="code"></param>
      protected ItemBase(string code)
         : base(code)
      { }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="code"></param>
      /// <param name="name"></param>
      protected ItemBase(string code, string name)
         : base(code, name)
      { }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sourceRow"></param>
      protected ItemBase(DataRow sourceRow)
         : base(sourceRow)
      { }

      #endregion

      #region public methods
      /// <summary>
      /// 默认以"项目名[规格]"的形式返回
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         if (!KeyInitialized)
            return "[--]";

         if ((KeyInitialized) && String.IsNullOrEmpty(Name))
            ReInitializeProperties();

         if (String.IsNullOrEmpty(Name))
            return String.Format(CultureInfo.CurrentCulture, "[{0}]", Code);
         else if (String.IsNullOrEmpty(Specification))
            return String.Format(CultureInfo.CurrentCulture, "{0}", Name.Trim());
         else
            return String.Format(CultureInfo.CurrentCulture, "{0}[{1}]", Name.Trim(), Specification.Trim());
      }
      #endregion
   }
}
