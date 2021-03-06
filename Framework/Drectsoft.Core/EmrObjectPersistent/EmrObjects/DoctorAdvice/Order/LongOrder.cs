using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace DrectSoft.Common.Eop
{
   /// <summary>
   /// 长期医嘱
   /// </summary> 
   public class LongOrder : Order
   {
      #region properties
      /// <summary>
      /// 停止信息
      /// </summary>
      public OrderOperateInfo CeaseInfo
      {
         get { return InnerCeaseInfo; }
      }
      internal OrderOperateInfo InnerCeaseInfo
      {
         get { return _ceaseInfo; }
         set { _ceaseInfo = value; }
      }
      private OrderOperateInfo _ceaseInfo;

      /// <summary>
      /// 停止审核信息
      /// </summary>
      public OrderOperateInfo CeaseAuditInfo
      {
         get { return InnerCeaseAuditInfo; }
      }
      internal OrderOperateInfo InnerCeaseAuditInfo
      {
         get { return _ceaseAuditInfo; }
         set { _ceaseAuditInfo = value; }
      }
      private OrderOperateInfo _ceaseAuditInfo;

      /// <summary>
      /// 停止原因
      /// </summary>
      public OrderCeaseReason CeaseReason
      {
         get { return InnerCeaseReason; }
      }
      internal OrderCeaseReason InnerCeaseReason
      {
         get { return _ceaseReason; }
         set { _ceaseReason = value; }
      }
      private OrderCeaseReason _ceaseReason;

      /// <summary>
      /// 与实体类匹配的、读取DB中数据的SQL语句
      /// </summary>
      public override string InitializeSentence
      {
         get { return ""; }
      }

      /// <summary>
      /// 在DataTable中按主键值过滤记录的条件
      /// </summary>
      public override string FilterCondition
      {
         get { return ""; }
      }

      // 得到产生术后医嘱的手术医嘱对象(当前医嘱类型是术后医嘱时有效)
      #endregion

      #region ctors
      /// <summary>
      /// 
      /// </summary>
      public LongOrder()
         : base()
      { }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sourceRow"></param>
      public LongOrder(DataRow sourceRow)
         : base(sourceRow)
      { }
      #endregion

      /// <summary>
      /// 停止医嘱(设置停止时间和停止者)
      /// </summary>
      /// <param name="employeeCode"></param>
      /// <param name="ceaseTime"></param>
      /// <param name="ceaseReason">停止原因</param>
      /// <returns></returns>
      public bool CeaseOrder(string employeeCode, DateTime ceaseTime, OrderCeaseReason ceaseReason)
      {
         if (ReadOnly)
            throw new InvalidOperationException(MessageStringManager.GetString("ObjectIsReadOnly"));

         if (_ceaseInfo == null)
            _ceaseInfo = new OrderOperateInfo(employeeCode, ceaseTime);
         else
            _ceaseInfo.SetPropertyValue(employeeCode, ceaseTime);

         _ceaseReason = ceaseReason;

         EditState = OrderEditState.Modified;

         FireOrderChanged(new OrderChangedEventArgs(SerialNo));
         return true;
      }

      /// <summary>
      /// 审核医嘱停止信息
      /// </summary>
      /// <param name="auditorCode"></param>
      /// <param name="auditTime"></param>
      /// <returns></returns>
      public bool AuditCeaseOrder(string auditorCode, DateTime auditTime)
      {
         if (ReadOnly)
            throw new InvalidOperationException(MessageStringManager.GetString("ObjectIsReadOnly"));

         // 只需要更新相应字段，不需要改变医嘱状态
         if (_ceaseAuditInfo == null)
            _ceaseAuditInfo = new OrderOperateInfo(auditorCode, auditTime);
         else
            _ceaseAuditInfo.SetPropertyValue(auditorCode, auditTime);

         EditState = OrderEditState.Modified;

         FireOrderChanged(new OrderChangedEventArgs(SerialNo));
         return true;
      }

      /// <summary>
      /// 将医嘱状态设为已停止
      /// </summary>
      public void SetStateToCeased()
      {
         if (InnerState == OrderState.Executed)
         {
            InnerState = OrderState.Ceased;
            EditState = OrderEditState.Modified;
         }
      }

      /// <summary>
      /// 将医嘱状态设为已停止
      /// </summary>
      /// <param name="ceaseReason">停止原因</param>
      public void SetStateToCeased(OrderCeaseReason ceaseReason)
      {
         if (InnerState == OrderState.Executed)
         {
            InnerState = OrderState.Ceased;
            EditState = OrderEditState.Modified;
            Memo = CeaseReason.ToString(); // 保留原始的停止原因，以便于恢复状态
            _ceaseReason = ceaseReason;
         }
      }

      /// <summary>
      /// 将符合指定条件的已停止医嘱的状态恢复到执行状态
      /// </summary>
      /// <param name="ceaseReason">停止原因</param>
      /// <param name="rollbackTime">恢复状态的时间点</param>
      public void RollbackStateOfCeasedOrder(OrderCeaseReason ceaseReason, DateTime rollbackTime)
      {
         // 如果停止原因和传入原因一致，且无停止时间或停止时间晚于当前日期，则将停止状态改成执行状态
         if ((InnerState == OrderState.Ceased) && (CeaseReason == ceaseReason))
         {
            if ((_ceaseInfo == null) || (!_ceaseInfo.HadInitialized) || (_ceaseInfo.ExecuteTime > rollbackTime))
            {
               InnerState = OrderState.Executed;
               Memo = "";
               EditState = OrderEditState.Modified;
               _ceaseReason = (OrderCeaseReason)Enum.Parse(typeof(OrderCeaseReason), Memo);
            }
         }
      }

      /// <summary>
      /// 初始化所有的属性，包括引用类型的属性自己的属性
      /// </summary>
      public override void ReInitializeAllProperties()
      {
         base.ReInitializeAllProperties();
         if (CeaseInfo != null)
            CeaseInfo.ReInitializeAllProperties();
         if (CeaseAuditInfo != null)
            CeaseAuditInfo.ReInitializeAllProperties();
      }
   }
}
