<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDown.aspx.cs" Inherits="DropDownAssignmnt.Properties.DropDown" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
    <style type="text/css">
        .auto-style1 {
            height: 34px;
        }
        .auto-style2 {
            height: 36px;
        }
        .auto-style3 {
            height: 89px;
        }
    </style>
   
</head>
<body style="width: 978px; height: 352px; margin-left: 29px">
    <form id="form1" runat="server" class="auto-style1">
        <div>
        </div>
        &emsp;
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">
       Select the State  : <asp:DropDownList ID="DropDownList1" runat="server" Height="32px" Width="127px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>

                    <br />
                    <asp:Image ID="Image1" runat="server" Height="133px" Width="202px" />

                </td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" Text="Capital City" Height="25px" Width="154px" OnClick="Button1_Click" />
                    <br />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Capital City is"></asp:Label>&emsp;
                    <asp:TextBox ID="TextBox1" runat="server" Width="193px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>

