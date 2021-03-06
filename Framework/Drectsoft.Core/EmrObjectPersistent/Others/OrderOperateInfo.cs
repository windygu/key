using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Globalization;

namespace DrectSoft.Common.Eop
{
   /// <summary>
   /// 医嘱操作信息结构体  
   /// </summary>
   public class OrderOperateInfo
   {
      /// <summary>
      /// 操作发生时间
      /// </summary>
      public DateTime ExecuteTime
      {
         get { return _executeTime; }
         set { _executeTime = value; }
      }
      internal string InnerExecuteTime
      {
         get 
         {
            if (_executeTime == DateTime.MinValue)
               return "";
            else
               return _executeTime.ToString("yyyy-MM-dd HH:mm:ss"); 
         }
         set
         {
            if (String.IsNullOrEmpty(value))
               _executeTime = DateTime.MinValue;
            else
               _executeTime = Convert.ToDateTime(value);
         }
      }
      private DateTime _executeTime;

      /// <summary>
      /// 操作执行者
      /// </summary>
      public Employee Executor
      {
         get 
         {
            if (_executor == null)
               _executor = new Employee();

            return _executor; 
         }
         set { _executor = value; }
      }
      private Employee _executor;

      /// <summary>
      /// 标记是否初始化过(含有有效数据)
      /// </summary>
      public bool HadInitialized
      {
         get
         {
            return ((Executor != null) && Executor.KeyInitialized && (ExecuteTime != DateTime.MinValue));
         }
      }

      #region ctor
      /// <summary>
      /// 
      /// </summary>
      public OrderOperateInfo()
      { }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="executorCode">医嘱操作执行者代码（职工代码）</param>
      /// <param name="executeTime">操作执行时间</param>
      public OrderOperateInfo(string executorCode, DateTime executeTime)
      {
         SetPropertyValue(executorCode, executeTime);
      }
      #endregion

      #region public method
      /// <summary>
      /// 提供赋值方法，以减少代码中对空值的判断
      /// </summary>
      /// <param name="executorCode"></param>
      /// <param name="executeTime"></param>
      public void SetPropertyValue(string executorCode, DateTime executeTime)
      {
         if (_executor == null)
            _executor = new Employee(executorCode);
         else
            _executor.Code = executorCode;
         _executeTime = executeTime;
      }

      /// <summary>
      /// 确定两个对象是否具有相同的值
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public override bool Equals(object obj)
      {
         if (obj == null)
            return false;
         OrderOperateInfo aimObj = (OrderOperateInfo)obj;
         if (aimObj != null)
         {            
            return (HadInitialized && aimObj.HadInitialized 
               && (aimObj.Executor.Code == Executor.Code)
               && (aimObj.ExecuteTime == ExecuteTime));
         }
         return false;
      }

      /// <summary>
      /// 返回该实例的哈希代码
      /// </summary>
      /// <returns></returns>
      public override int GetHashCode()
      {
         return Executor.GetHashCode();
      }

      /// <summary>
      /// 获取对象的 Expression（如果存在的话）
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         if (!HadInitialized)
            return "";
         else if (String.IsNullOrEmpty(Executor.Name))
            return String.Format(CultureInfo.CurrentCulture
               , "[{0}]在{1:yy-M-d H:mm}执行", Executor.Code, ExecuteTime);
         else
            return String.Format(CultureInfo.CurrentCulture
               , "{0}在{1:yy-M-d H:mm}执行", Executor.Name, ExecuteTime);
      }

      /// <summary>
      /// 初始化所有的属性，包括引用类型的属性自己的属性
      /// </summary>
      public void ReInitializeAllProperties()
      {
         Executor.ReInitializeAllProperties();
      }
      #endregion
   }
}
