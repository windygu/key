using System;

namespace XDesignerCommon
{
	/// <summary>
	/// 度量转换模块,本对象不可实例化
	/// </summary>
	public sealed class MeasureConvert
	{
		/// <summary>
		/// 将英寸转换为毫米
		/// </summary>
		/// <param name="vValue">英寸值</param>
		/// <returns>毫米值</returns>
		public static double InchToMillimeter( double vValue )
		{
			return vValue * 25.4 ;
		}
		/// <summary>
		/// 将毫米转换为英寸
		/// </summary>
		/// <param name="vValue">毫米值</param>
		/// <returns>英寸值</returns>
		public static double MillimeterToInch( double vValue )
		{
			return vValue / 25.4 ;
		}
		/// <summary>
		/// 将文档单位转换为毫米数
		/// </summary>
		/// <param name="vValue">文档单位值</param>
		/// <returns>毫米值</returns>
		public static double DocumentToMillimeter( double vValue )
		{
			return vValue * 0.254 / 3 ;
		}
		/// <summary>
		/// 将毫米值转换为文档值
		/// </summary>
		/// <param name="vValue">毫米值</param>
		/// <returns>文档值</returns>
		public static double MillimeterToDocument( double vValue )
		{
			return vValue * 3 / 0.254 ;
		}
		/// <summary>
		/// 将百分之一英寸转换为毫米值
		/// </summary>
		/// <param name="vValue">百分之一英寸值</param>
		/// <returns>毫米值</returns>
		public static double HundredthsInchToMillimeter( double vValue )
		{
			return vValue * 0.254 ;
		}
		/// <summary>
		/// 将毫米值转换为百分之一英寸值
		/// </summary>
		/// <param name="vValue">毫米值</param>
		/// <returns>百分之一英寸值</returns>
		public static double MillimeterToHundredthsInch( double vValue )
		{
			return vValue / 0.254 ;
		}
		/// <summary>
		/// 将英寸转换为厘米
		/// </summary>
		/// <param name="vValue">英寸值</param>
		/// <returns>厘米值</returns>
		public static double InchToCentimeter( double vValue )
		{
			return vValue * 2.54 ;
		}
		/// <summary>
		/// 将英尺转换为英寸
		/// </summary>
		/// <param name="vValue">英尺值</param>
		/// <returns>英寸值</returns>
		public static double FootToInch( double vValue )
		{
			return vValue * 12 ;
		}
		/// <summary>
		/// 将英尺转换为米
		/// </summary>
		/// <param name="vValue">英尺值</param>
		/// <returns>米值</returns>
		public static double FootToRice( double vValue )
		{
			return vValue * 0.3048 ;
		}


		/// <summary>
		/// 本对象不可实例化
		/// </summary>
		private MeasureConvert()
		{
		}
	}//public sealed class MeasureConvert
}
