// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Reelity.Portal.Web.Models.Basics;
using Reelity.Portal.Web.Views.Bases;

namespace Reelity.Portal.Web.Views.Components
{
    public partial class StudentFormComponent : ComponentBase
    {
        public TextBoxBase StudentNameTextBox { get; set; }
        public ComponentState State { get; set; }

        protected override void OnInitialized()
        {
            this.State = ComponentState.Content;
        }
    }
}
