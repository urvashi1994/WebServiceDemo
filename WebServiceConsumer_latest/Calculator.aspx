<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebServiceConsumer_latest.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div style="margin: 0px auto; padding-left: 370px; padding-right: 30px; overflow: auto;">
            <div>
                <table width="50%">
                    <tr>
                        <td colspan="2" style="background-color: Green; height: 30px; color: White;" align="center">Calculator
                        </td>
                    </tr>
                    <tr>
                        <td>First Number </td>
                        <td>
                            <asp:TextBox ID="txtFirstNumber" Width="150px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Second Number </td>
                        <td>
                            <asp:TextBox ID="txtSecondNumber" Width="150px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                     <tr>
                        <td>Total</td>
                        <td>
                            <asp:Label ID="lblTotal" Width="150px" runat="server"></asp:Label>
                        </td>
                    </tr>
                   
                    <tr>
                        <td align="center" colspan="2">
                            <asp:Button ID="btnAdd" runat="server" Width="100px" Text="Addition" OnClick="BtnAdd_Click" />
                            <asp:Button ID="btnSubtract" runat="server" Width="100px" Text="Subtraction" OnClick="BtnSubtract_Click" />
                            <asp:Button ID="btnmultiply" runat="server" Width="100px" Text="Multiplication" OnClick="Btnmultiply_Click" />
                            <asp:Button ID="btndivide" runat="server" Width="100px" Text="Division" OnClick="Btndivide_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>

        <div>
        </div>
    </form>
</body>
</html>
