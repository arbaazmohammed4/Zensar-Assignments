<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Va;idationsForm.aspx.cs" Inherits="ASPValidatorAssignment.Properties.Va_idationsForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Insert Your Details </P> 
            Name:  <asp:TextBox ID="Name" runat="server" OnTextChanged="Name_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Cannot Be Blank" ForeColor="Red" ControlToValidate="Name"></asp:RequiredFieldValidator>
            <br />


            Family Name:<asp:TextBox ID="FamilyName" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Other Than Name" ControlToCompare="Name" ControlToValidate="FamilyName" ForeColor="Red" Operator="NotEqual"></asp:CompareValidator>
            <br />


            Address: <asp:TextBox ID="Address" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="Address" ErrorMessage="Atleast 2 Characters" ForeColor="Red" ValidationExpression="^[a-zA-Z-\s\{2,}]+$"></asp:RegularExpressionValidator>
            <br />


            City: <asp:TextBox ID="City" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="City" ErrorMessage="Atleast two Characters" ForeColor="Red" ValidationExpression="^[a-zA-Z-\s\{2,}]+$"></asp:RegularExpressionValidator>
            <br />


            Zip Code: <asp:TextBox ID="ZipCode" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="ZipCode" ErrorMessage="( xxxxx )" ForeColor="Red" ValidationExpression="\d{5}"></asp:RegularExpressionValidator>
            <br />



            Phone: <asp:TextBox ID="Phn" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Phn" ErrorMessage="( xx-xxxxxxxx / xxx-xxxxxxxxx )" ForeColor="Red" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
            <br />



            Email:         <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Email" ErrorMessage="example@email.com" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />


        </div>
       
          <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    
                    <asp:Button ID="Button1" runat="server" Text="Check" />
                </td>
                <td>&nbsp;</td>
            </tr>
    </form>
</body>
</html>

