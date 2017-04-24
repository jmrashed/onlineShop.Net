<%@ Page Language="C#" MasterPageFile="~/User/MasterUser.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="Visitor_signup" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;" class="content">
        <tr>
            <td colspan="2">
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>        
        <tr>
            <td colspan="2">
            </td>
        </tr>       
         <tr>
            <td colspan="2">
                <h1>&nbsp;&nbsp;&nbsp;&nbsp;***Account Details:</h1>
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>        
        <tr>
            <td><h3>User Name:&nbsp;&nbsp;&nbsp;</h3></td>
            <td><asp:TextBox ID="textUsername" runat="server" Width="260px" Font-Size="20px"></asp:TextBox>
                <asp:Label ID="labelUsernameError" runat="server" Font-Size="12pt" 
                    ForeColor="#996633" Text="Username is not Available." Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td><h3>Password:&nbsp;&nbsp;&nbsp;</h3></td>
            <td><asp:TextBox ID="textPassword" runat="server" Width="260px" Font-Size="20px" 
                    TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td><h3>Re-enter Password:&nbsp;&nbsp;&nbsp;</h3></td>
            <td><asp:TextBox ID="textReenterpassword" runat="server" Width="260px" 
                    Font-Size="20px" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td><h3>E-mail Address:&nbsp;&nbsp;&nbsp;</h3></td>
            <td><asp:TextBox ID="textEmail" runat="server" Width="260px" Font-Size="20px"></asp:TextBox>
                <asp:Label ID="labelEmailError" runat="server" Font-Size="12pt" 
                    ForeColor="#996633" Text="Email is already registered." Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>        
         <tr>
            <td colspan="2">
                <h1>&nbsp;&nbsp;&nbsp;&nbsp;***Personal Details:</h1>
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>        
        <tr>
            <td><h3>First Name:&nbsp;&nbsp;&nbsp;</h3></td>
            <td><asp:TextBox ID="textFirstname" runat="server" Width="260px" Font-Size="20px"></asp:TextBox></td>
        </tr>
        <tr>
            <td><h3>Last Name:&nbsp;&nbsp;&nbsp;</h3></td>
            <td>
                <asp:TextBox ID="textLastname" runat="server" Width="260px" Font-Size="20px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><h3>Gender:&nbsp;&nbsp;&nbsp;</h3></td>
            <td>
                <asp:DropDownList ID="dropGender" runat="server" Height="29px" Width="90px" >
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><h3>Address:&nbsp;&nbsp;&nbsp;</h3></td>
            <td>
                <asp:TextBox ID="textAddress" runat="server" Width="400px" Font-Size="20px" Height="100px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><h3>City:&nbsp;&nbsp;&nbsp;</h3></td>
            <td>
                <asp:TextBox ID="textCity" runat="server" Width="260px" Font-Size="20px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><h3>State:&nbsp;&nbsp;&nbsp;</h3></td>
            <td>
                <asp:TextBox ID="textState" runat="server" Width="260px" Font-Size="20px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><h3>Pincode:&nbsp;&nbsp;&nbsp;</h3></td>
            <td>
                <asp:TextBox ID="textPincode" runat="server" Width="260px" Font-Size="20px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><h3>Mobile No:&nbsp;&nbsp;&nbsp;</h3></td>
            <td>
                <asp:TextBox ID="textMobile" runat="server" Width="260px" Font-Size="20px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>        
        <tr>
            <td align="right">
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/Save.gif" 
                    Height="29px" Width="130px" onclick="ImageButton2_Click"/>
                &nbsp;&nbsp;
            </td>
            <td>
                &nbsp;&nbsp;
               <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Images/Cancel.gif" 
                    Height="29px" onclick="ImageButton3_Click" Width="130px"/>
            </td>
        </tr>
        <tr>
            <td align="right">
                &nbsp;</td>
            <td>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

