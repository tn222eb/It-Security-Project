<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Register.aspx.cs" Inherits="Forum_It_Security_Project.Account.Register" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ValidationSummary ID="ValidationSummary" runat="server" CssClass="validationcolor" ValidationGroup="RegisterValidation"
        HeaderText="An error has occured, please correct the errors and try again." />
    <asp:CreateUserWizard ID="RegisterUser" runat="server" EnableViewState="false" OnCreatedUser="RegisterUser_CreatedUser">
        <LayoutTemplate>
            <asp:PlaceHolder ID="wizardStepPlaceholder" runat="server"></asp:PlaceHolder>
            <asp:PlaceHolder ID="navigationPlaceholder" runat="server"></asp:PlaceHolder>
        </LayoutTemplate>
        <WizardSteps>
            <asp:CreateUserWizardStep ID="RegisterUserWizardStep" runat="server">
                <ContentTemplate>
                    <h2>Create a New Account
                    </h2>
                    <p>
                        Use the form below to create a new account.
                    </p>
                    <p>
                        Passwords are required to be a minimum of <%= Membership.MinRequiredPasswordLength %> characters in length.
                    </p>
                    <span class="failureNotification">
                        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
                    </span>
                    <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" CssClass="failureNotification"
                        ValidationGroup="RegisterUserValidationGroup" />
                    <div class="accountInfo">
                        <fieldset class="register">
                            <legend>Account Information</legend>
                            <p>
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                                <asp:TextBox ID="Username" runat="server" CssClass="textEntry" MaxLength="30"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UsernameRequiredFieldValidator" runat="server" Display="Dynamic" ValidationGroup="RegisterValidation"
                                    ErrorMessage="You have to write in a username!" ControlToValidate="Username">*</asp:RequiredFieldValidator>
                                <div class="left">
                            </p>
                            <p>
                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password" MaxLength="30"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PasswordRequiredFieldValidator" runat="server" Display="Dynamic" ValidationGroup="RegisterValidation"
                                    ErrorMessage="You have to write in a Password!" ControlToValidate="Password">*</asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirm Password:</asp:Label>
                                <asp:TextBox ID="ConfirmPassword" runat="server" CssClass="passwordEntry" TextMode="Password" MaxLength="30"></asp:TextBox>
                                <asp:CompareValidator ID="ConfirmPasswordCompareValidator" runat="server" ErrorMessage="Your Password doesn't match!"
                                    ControlToCompare="Password" ControlToValidate="ConfirmPassword" ValidationGroup="RegisterValidation" CommandName="Insert" OnClick="RegisterButton_OnClick">*</asp:CompareValidator>
                                <asp:RequiredFieldValidator ID="ConfirmPasswordRequiredFieldValidator" runat="server" Display="Dynamic" ValidationGroup="RegisterValidation"
                                    ErrorMessage="You have to confirm your password!" ControlToValidate="ConfirmPasswordTextBox">*</asp:RequiredFieldValidator>
                            </p>
                        </fieldset>
                        <p class="submitButton">
                            <asp:Button ID="CreateUserButton" runat="server" CommandName="MoveNext" Text="Create User"
                                ValidationGroup="RegisterUserValidationGroup" CausesValidation="true" />
                        </p>
                    </div>
                </ContentTemplate>
                <CustomNavigationTemplate>
                </CustomNavigationTemplate>
            </asp:CreateUserWizardStep>
        </WizardSteps>
    </asp:CreateUserWizard>
</asp:Content>
