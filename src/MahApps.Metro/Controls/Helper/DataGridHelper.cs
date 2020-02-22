﻿using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace MahApps.Metro.Controls
{
    public static class DataGridHelper
    {
        private static DataGrid _suppressComboAutoDropDown;

        public static readonly DependencyProperty AutoGeneratedCheckBoxColumnStyleProperty
            = DependencyProperty.RegisterAttached(
                "AutoGeneratedCheckBoxColumnStyle",
                typeof(Style),
                typeof(DataGridHelper),
                new PropertyMetadata(default(Style), AutoGeneratedCheckBoxColumnStylePropertyChangedCallback));

        private static void AutoGeneratedCheckBoxColumnStylePropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            if (dependencyObject is DataGrid dataGrid)
            {
                dataGrid.AutoGeneratingColumn += (s, e) =>
                    {
                        if (e.Column is DataGridCheckBoxColumn dataGridCheckBoxColumn)
                        {
                            dataGridCheckBoxColumn.ElementStyle = GetAutoGeneratedCheckBoxColumnStyle(dependencyObject);
                        }
                    };
            }
        }

        /// <summary>
        /// Gets the ElementStyle for the autogenerated DataGridCheckBoxColumn.
        /// </summary>
        [Category(AppName.MahApps)]
        [AttachedPropertyBrowsableForType(typeof(DataGrid))]
        public static Style GetAutoGeneratedCheckBoxColumnStyle(DependencyObject element)
        {
            return (Style)element.GetValue(AutoGeneratedCheckBoxColumnStyleProperty);
        }

        /// <summary>
        /// Sets the ElementStyle for the autogenerated DataGridCheckBoxColumn.
        /// </summary>
        [Category(AppName.MahApps)]
        [AttachedPropertyBrowsableForType(typeof(DataGrid))]
        public static void SetAutoGeneratedCheckBoxColumnStyle(DependencyObject element, Style value)
        {
            element.SetValue(AutoGeneratedCheckBoxColumnStyleProperty, value);
        }

        public static readonly DependencyProperty AutoGeneratedCheckBoxColumnEditingStyleProperty
            = DependencyProperty.RegisterAttached(
                "AutoGeneratedCheckBoxColumnEditingStyle",
                typeof(Style),
                typeof(DataGridHelper),
                new PropertyMetadata(default(Style), AutoGeneratedCheckBoxColumnEditingStylePropertyChangedCallback));

        private static void AutoGeneratedCheckBoxColumnEditingStylePropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            if (dependencyObject is DataGrid dataGrid)
            {
                dataGrid.AutoGeneratingColumn += (s, e) =>
                    {
                        if (e.Column is DataGridCheckBoxColumn dataGridCheckBoxColumn)
                        {
                            dataGridCheckBoxColumn.EditingElementStyle = GetAutoGeneratedCheckBoxColumnEditingStyle(dependencyObject);
                        }
                    };
            }
        }

        /// <summary>
        /// Gets the EditingElementStyle for the autogenerated DataGridCheckBoxColumn.
        /// </summary>
        [Category(AppName.MahApps)]
        [AttachedPropertyBrowsableForType(typeof(DataGrid))]
        public static Style GetAutoGeneratedCheckBoxColumnEditingStyle(DependencyObject element)
        {
            return (Style)element.GetValue(AutoGeneratedCheckBoxColumnEditingStyleProperty);
        }

        /// <summary>
        /// Sets the EditingElementStyle for the autogenerated DataGridCheckBoxColumn.
        /// </summary>
        [Category(AppName.MahApps)]
        [AttachedPropertyBrowsableForType(typeof(DataGrid))]
        public static void SetAutoGeneratedCheckBoxColumnEditingStyle(DependencyObject element, Style value)
        {
            element.SetValue(AutoGeneratedCheckBoxColumnEditingStyleProperty, value);
        }

        public static readonly DependencyProperty AutoGeneratedTextColumnEditingStyleProperty
            = DependencyProperty.RegisterAttached(
                "AutoGeneratedTextColumnEditingStyle",
                typeof(Style),
                typeof(DataGridHelper),
                new PropertyMetadata(default(Style), AutoGeneratedTextColumnEditingStylePropertyChangedCallback));

        private static void AutoGeneratedTextColumnEditingStylePropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            if (dependencyObject is DataGrid dataGrid)
            {
                dataGrid.AutoGeneratingColumn += (s, e) =>
                    {
                        if (e.Column is DataGridTextColumn dataGridTextColumn)
                        {
                            dataGridTextColumn.EditingElementStyle = GetAutoGeneratedTextColumnEditingStyle(dependencyObject);
                        }
                    };
            }
        }

        /// <summary>
        /// Gets the EditingElementStyle for the autogenerated DataGridTextColumn.
        /// </summary>
        [Category(AppName.MahApps)]
        [AttachedPropertyBrowsableForType(typeof(DataGrid))]
        public static Style GetAutoGeneratedTextColumnEditingStyle(DependencyObject element)
        {
            return (Style)element.GetValue(AutoGeneratedTextColumnEditingStyleProperty);
        }

        /// <summary>
        /// Sets the EditingElementStyle for the autogenerated DataGridTextColumn.
        /// </summary>
        [Category(AppName.MahApps)]
        [AttachedPropertyBrowsableForType(typeof(DataGrid))]
        public static void SetAutoGeneratedTextColumnEditingStyle(DependencyObject element, Style value)
        {
            element.SetValue(AutoGeneratedTextColumnEditingStyleProperty, value);
        }

        public static readonly DependencyProperty CellPaddingProperty
            = DependencyProperty.RegisterAttached(
                "CellPadding",
                typeof(Thickness),
                typeof(DataGridHelper),
                new FrameworkPropertyMetadata(new Thickness(0), FrameworkPropertyMetadataOptions.Inherits));

        /// <summary>
        /// Gets the padding inside the cell.
        /// </summary>
        [Category(AppName.MahApps)]
        [AttachedPropertyBrowsableForType(typeof(DataGrid))]
        [AttachedPropertyBrowsableForType(typeof(DataGridRow))]
        public static Thickness GetCellPadding(DependencyObject element)
        {
            return (Thickness)element.GetValue(CellPaddingProperty);
        }

        /// <summary>
        /// Sets the padding inside the cell.
        /// </summary>
        [Category(AppName.MahApps)]
        [AttachedPropertyBrowsableForType(typeof(DataGrid))]
        [AttachedPropertyBrowsableForType(typeof(DataGridRow))]
        public static void SetCellPadding(DependencyObject element, Thickness value)
        {
            element.SetValue(CellPaddingProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderPaddingProperty
            = DependencyProperty.RegisterAttached(
                "ColumnHeaderPadding",
                typeof(Thickness),
                typeof(DataGridHelper),
                new FrameworkPropertyMetadata(new Thickness(10, 0, 4, 0), FrameworkPropertyMetadataOptions.Inherits));

        /// <summary>
        /// Gets the padding inside the column.
        /// </summary>
        [Category(AppName.MahApps)]
        [AttachedPropertyBrowsableForType(typeof(DataGrid))]
        public static Thickness GetColumnHeaderPadding(DependencyObject element)
        {
            return (Thickness)element.GetValue(ColumnHeaderPaddingProperty);
        }

        /// <summary>
        /// Sets the padding inside the column.
        /// </summary>
        [Category(AppName.MahApps)]
        [AttachedPropertyBrowsableForType(typeof(DataGrid))]
        public static void SetColumnHeaderPadding(DependencyObject element, Thickness value)
        {
            element.SetValue(ColumnHeaderPaddingProperty, value);
        }

        public static readonly DependencyProperty EnableCellEditAssistProperty
            = DependencyProperty.RegisterAttached(
                "EnableCellEditAssist",
                typeof(bool),
                typeof(DataGridHelper),
                new PropertyMetadata(default(bool), EnableCellEditAssistPropertyChangedCallback));

        /// <summary>
        /// Gets a value which indicates the preview cell editing is enabled or not.
        /// </summary>
        [Category(AppName.MahApps)]
        [AttachedPropertyBrowsableForType(typeof(DataGrid))]
        public static bool GetEnableCellEditAssist(DependencyObject element)
        {
            return (bool)element.GetValue(EnableCellEditAssistProperty);
        }

        /// <summary>
        /// Sets a value which indicates the preview cell editing is enabled or not.
        /// </summary>
        [Category(AppName.MahApps)]
        [AttachedPropertyBrowsableForType(typeof(DataGrid))]
        public static void SetEnableCellEditAssist(DependencyObject element, bool value)
        {
            element.SetValue(EnableCellEditAssistProperty, value);
        }

        private static void EnableCellEditAssistPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var dataGrid = d as DataGrid;
            if (dataGrid == null)
            {
                return;
            }

            dataGrid.PreviewMouseLeftButtonDown -= DataGridOnPreviewMouseLeftButtonDown;
            if ((bool)e.NewValue)
            {
                dataGrid.PreviewMouseLeftButtonDown += DataGridOnPreviewMouseLeftButtonDown;
            }
        }

        private static void DataGridOnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var dataGrid = (DataGrid)sender;

            var inputHitTest = dataGrid.InputHitTest(e.GetPosition((DataGrid)sender)) as DependencyObject;

            while (inputHitTest != null)
            {
                var dataGridCell = inputHitTest as DataGridCell;
                if (dataGridCell != null && dataGrid.Equals(dataGridCell.TryFindParent<DataGrid>()))
                {
                    if (dataGridCell.IsReadOnly) return;

                    ToggleButton toggleButton;
                    ComboBox comboBox;
                    if (IsDirectHitOnEditComponent(dataGridCell, e, out toggleButton))
                    {
                        dataGrid.CurrentCell = new DataGridCellInfo(dataGridCell);
                        dataGrid.BeginEdit();
                        toggleButton.SetCurrentValue(ToggleButton.IsCheckedProperty, !toggleButton.IsChecked);
                        dataGrid.CommitEdit();
                        e.Handled = true;
                    }
                    else if (IsDirectHitOnEditComponent(dataGridCell, e, out comboBox))
                    {
                        if (_suppressComboAutoDropDown != null) return;

                        dataGrid.CurrentCell = new DataGridCellInfo(dataGridCell);
                        dataGrid.BeginEdit();
                        //check again, as we move to  the edit  template
                        if (IsDirectHitOnEditComponent(dataGridCell, e, out comboBox))
                        {
                            _suppressComboAutoDropDown = dataGrid;
                            comboBox.DropDownClosed += ComboBoxOnDropDownClosed;
                            comboBox.IsDropDownOpen = true;
                        }
                        e.Handled = true;
                    }

                    return;
                }

                inputHitTest = (inputHitTest is Visual || inputHitTest is Visual3D)
                    ? VisualTreeHelper.GetParent(inputHitTest)
                    : null;
            }
        }

        private static void ComboBoxOnDropDownClosed(object sender, EventArgs eventArgs)
        {
            _suppressComboAutoDropDown.CommitEdit();
            _suppressComboAutoDropDown = null;
            ((ComboBox)sender).DropDownClosed -= ComboBoxOnDropDownClosed;
        }

        private static bool IsDirectHitOnEditComponent<TControl>(ContentControl contentControl, MouseEventArgs e, out TControl control)
            where TControl : Control
        {
            control = contentControl.Content as TControl;
            if (control == null)
            {
                return false;
            }

            var frameworkElement = VisualTreeHelper.GetChild(contentControl, 0) as FrameworkElement;
            if (frameworkElement == null)
            {
                return false;
            }

            var transformToAncestor = (MatrixTransform)control.TransformToAncestor(frameworkElement);
            var rect = new Rect(new Point(transformToAncestor.Value.OffsetX, transformToAncestor.Value.OffsetY),
                                new Size(control.ActualWidth, control.ActualHeight));

            return rect.Contains(e.GetPosition(frameworkElement));
        }

        public static readonly DependencyProperty SelectionUnitProperty
            = DependencyProperty.RegisterAttached("SelectionUnit",
                                                  typeof(DataGridSelectionUnit),
                                                  typeof(DataGridHelper),
                                                  new FrameworkPropertyMetadata(DataGridSelectionUnit.FullRow));

        /// <summary>
        /// Gets the value to define the selection behavior.
        /// </summary>
        [Category(AppName.MahApps)]
        [AttachedPropertyBrowsableForType(typeof(DataGridRow))]
        [AttachedPropertyBrowsableForType(typeof(DataGridCell))]
        public static DataGridSelectionUnit GetSelectionUnit(UIElement element)
        {
            return (DataGridSelectionUnit)element.GetValue(SelectionUnitProperty);
        }

        /// <summary>
        /// Sets the value to define the selection behavior.
        /// </summary>
        [Category(AppName.MahApps)]
        [AttachedPropertyBrowsableForType(typeof(DataGridRow))]
        [AttachedPropertyBrowsableForType(typeof(DataGridCell))]
        public static void SetSelectionUnit(UIElement element, DataGridSelectionUnit value)
        {
            element.SetValue(SelectionUnitProperty, value);
        }
    }
}