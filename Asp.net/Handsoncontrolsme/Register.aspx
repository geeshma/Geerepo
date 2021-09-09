<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Handsoncontrolsme.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br>
    <table>
        <tr>

        </tr>
    </table>
    <table align="center" style="width: 50%">
        <tr>
            <td>Name*</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredName"   ControlToValidate="txtName"  runat="server" ErrorMessage="RequiredName"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Gender</td>
            <td>
                <asp:RadioButton ID="rbtMale" runat="server" />
                <br />
                <asp:RadioButton ID="rbtFemale" runat="server" />
            </td>
        </tr>
        <tr>
            <td>EmailId*</td>
            <td>
                <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredEmail" ControlToValidate="Email"  runat="server" ErrorMessage="RequiredEmail"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Mobile*</td>
            <td>
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredMobilenumber" ControlToValidate="txtMobile" runat="server" ErrorMessage="RequiredMobilenumberr"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Joindate</td>
            <td>
                <asp:TextBox ID="Joindate" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Country</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>India</asp:ListItem>
                    <asp:ListItem>USA</asp:ListItem>
                    <asp:ListItem>California</asp:ListItem>
                    <asp:ListItem>Japan</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Password*</td>
            <td>
                <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="Password" runat="server" ErrorMessage="RequiredPassword"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Confirm Password</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:CheckBox ID="checkBox1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnregister" runat="server" Text="Register" OnClick="SignUp" />
            </td>
        </tr>
    </table>
</asp:Content>
