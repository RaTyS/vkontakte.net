// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VisibleOrHiddenConverter.cs" company="������� ���� - ������������� ����������">
//   ��� ����� �������� (�) 2010-2011
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicSearcher
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    /// <summary>
    /// ��������� ��� ������� �������� � ����������� �� ���� ���� bool
    /// </summary>
    public class VisibilityConverter : IValueConverter
    {
        #region Implemented Interfaces

        #region IValueConverter

        /// <summary>
        /// �������������� bool � Visiblility
        /// </summary>
        /// <param name="value">
        /// �������� ���� 
        /// </param>
        /// <param name="targetType">
        /// �������� ��� ?
        /// </param>
        /// <param name="parameter">
        /// �� ������������
        /// </param>
        /// <param name="culture">
        /// ���������� � ��������
        /// </param>
        /// <returns>
        /// ���������� ��������� ��������� ��������� � �������� ����
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return (bool)value ? Visibility.Visible : (Visibility)Enum.Parse(typeof(Visibility), parameter.ToString());
            }
            catch (Exception)
            {
                return DependencyProperty.UnsetValue;
            }
        }

        /// <summary>
        /// �������������� Visibility � bool
        /// </summary>
        /// <param name="value">
        /// �������� ����
        /// </param>
        /// <param name="targetType">
        /// �������� ���
        /// </param>
        /// <param name="parameter">
        /// �������� ��������� � radioButton
        /// </param>
        /// <param name="culture">
        /// ���������� � ��������
        /// </param>
        /// <returns>
        /// ���������� �������� ������� ����� ��������� ����
        /// </returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return (Visibility)value == Visibility.Visible ? true : false;
            }
            catch (Exception)
            {
                return DependencyProperty.UnsetValue;
            }
        }

        #endregion

        #endregion
    }
}