﻿/*flexberryautogenerated="true"*/
namespace IIS.arm
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class накладнаяL : BaseListForm<накладная>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public накладнаяL() : base(накладная.Views.накладнаяL)
        {
            EditPage = накладнаяE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/nakladnaya/nakladnayaL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}
