using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;


using System.Globalization;

namespace DrectSoft.Common.Eop
{
   /// <summary>
   /// 收费小项目
   /// </summary> 
   public class ChargeItem : ItemBase
   {
      #region properties
      /// <summary>
      /// 项目大类代码
      /// TODO: 暂时用代码字段，以后改成对象
      /// </summary>
      public string ItemCatalog
      {
         get { return _itemCatalog; }
         set { _itemCatalog = value; }
      }
      private string _itemCatalog;

      /// <summary>
      /// 项目性质
      /// </summary>
      public ItemAttributeFlag Attributes
      {
         get { return _attributes; }
         set { _attributes = value; }
      }
      private ItemAttributeFlag _attributes;

      /// <summary>
      /// 显示控制属性
      /// </summary>
      public ItemPrintAttributeFlag PrintAttributes
      {
         get { return _printAttributes; }
         set { _printAttributes = value; }
      }
      private ItemPrintAttributeFlag _printAttributes;

      /// <summary>
      /// 附加信息(提供额外的处理信息,比如对应的手术代码)
      /// </summary>
      public string PlugInformation
      {
         get { return _plugInformation; }
         set { _plugInformation = value; }
      }
      private string _plugInformation;

      /// <summary>
      /// 与实体类匹配的、读取DB中数据的SQL语句
      /// </summary>
      public override string InitializeSentence
      {
         get { return GetQuerySentenceFromXml("SelectChargeItem"); }
      }

      /// <summary>
      /// 在DataTable中按主键值过滤记录的条件
      /// </summary>
      public override string FilterCondition
      {
          get { return "ItemID = '" + Code.Trim() + "'"; }
      }
      #endregion

      #region ctor
      /// <summary>
      /// 
      /// </summary>
      public ChargeItem()
         : base()
      { }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="code"></param>
      public ChargeItem(string code)
         : base(code)
      { }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="code"></param>
      /// <param name="name"></param>
      public ChargeItem(string code, string name)
         : base(code, name)
      { }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sourceRow"></param>
      public ChargeItem(DataRow sourceRow)
         : base(sourceRow)
      { }
      #endregion

      #region public methods
      /// <summary>
      /// 初始化所有的属性，包括引用类型的属性自己的属性
      /// </summary>
      public override void ReInitializeAllProperties()
      {
         ReInitializeProperties();
      }
      #endregion

   }

   #region 增加临床项目支持

   /// <summary>
   /// 收费小项目
   /// </summary> 
   public class ClinicItem : ItemBase
   {
      #region properties

      /// <summary>
      /// 与实体类匹配的、读取DB中数据的SQL语句
      /// </summary>
      public override string InitializeSentence
      {
         get { return GetQuerySentenceFromXml("SelectClinicItem"); }
      }

      /// <summary>
      /// 在DataTable中按主键值过滤记录的条件
      /// </summary>
      public override string FilterCondition
      {
         get { return "ID = '" + Code.Trim() + "'"; }
      }
      #endregion

      #region ctor
      /// <summary>
      /// 
      /// </summary>
      public ClinicItem()
         : base()
      { }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="code"></param>
      public ClinicItem(string code)
         : base(code)
      { }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="code"></param>
      /// <param name="name"></param>
      public ClinicItem(string code, string name)
         : base(code, name)
      { }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sourceRow"></param>
      public ClinicItem(DataRow sourceRow)
         : base(sourceRow)
      { }
      #endregion

      #region public methods
      /// <summary>
      /// 初始化所有的属性，包括引用类型的属性自己的属性
      /// </summary>
      public override void ReInitializeAllProperties()
      {
         ReInitializeProperties();
      }
      #endregion

   }
   #endregion

}