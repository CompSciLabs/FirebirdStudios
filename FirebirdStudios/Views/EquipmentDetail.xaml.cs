using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FirebirdStudios
{
	public partial class EquipmentDetail : ContentPage
	{
		public EquipmentDetail(Equipment equipment)
		{
			if (equipment == null)
			{
				throw new ArgumentNullException();
			}
			BindingContext = equipment;
			InitializeComponent();

		}
	}
}
