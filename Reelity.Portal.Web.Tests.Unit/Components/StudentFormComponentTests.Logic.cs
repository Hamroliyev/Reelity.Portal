// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using FluentAssertions;
using Reelity.Portal.Web.Models.Basics;
using Reelity.Portal.Web.Views.Components;

namespace Reelity.Portal.Web.Tests.Unit.Components
{
    public partial class StudentFormComponentTests
    {
        [Fact]
        public void ShouldInitializeComponent()
        {
            // given . when
            var initialStudentFormComponent = new StudentFormComponent();

            // then
            initialStudentFormComponent.StudentNameTextBox.Should().BeNull();
        }

        [Fact]
        public void ShouldRenderComponent()
        {
            // given
            ComponentState expectedComponentState = ComponentState.Content;

            // when
            this.renderedStudentFormComponent = 
                Render<StudentFormComponent>();

            // then
            this.renderedStudentFormComponent.Instance.State
                .Should().Be(expectedComponentState);   

            this.renderedStudentFormComponent.Instance.StudentNameTextBox
                .Should().NotBeNull();

            this.renderedStudentFormComponent.Instance.StudentNameTextBox.PlaceHolder
                .Should().Be("Name");
        }
    }
}
