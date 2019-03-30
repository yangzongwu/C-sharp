// pic :https://photos.google.com/search/_tra_/photo/AF1QipPkmMmeH3zj-Mm_eH2q0FNGm6ZNPxEg8yadU3h-
//===========================Webform1.aspx=========================================================
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="font-family:Arial;border:1px solid black; text-align:center">
                <tr>
                    <td><b>Customer 1</b></td>
                    <td></td>
                    <td><b>Customer 2</b></td>
                    <td></td>
                    <td><b>Customer 3</b></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCounter1" runat="server" BackColor="#000099" BorderColor="White" Font-Size="Larger" ></asp:TextBox></td>
                    <td></td>
                    <td>
                        <asp:TextBox ID="txtCounter2" runat="server" BackColor="#000099" BorderColor="White" Font-Size="Larger"></asp:TextBox></td>
                    <td></td>
                    <td>
                        <asp:TextBox ID="txtCounter3" runat="server" BackColor="#000099" BorderColor="White" Font-Size="Larger"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCounter1" runat="server" Text="Next" Width="150px" OnClick="btnCounter1_Click" /></td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnCounter2" runat="server" Text="Next" Width="150px" OnClick="btnCounter2_Click" /></td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnCounter3" runat="server" Text="Next" Width="150px" OnClick="btnCounter3_Click" /></td>
                </tr>
                <tr><td colspan="5">
                    <asp:TextBox ID="txtDisplay" runat="server" BackColor="#009933" BorderColor="#0066FF" Font-Size="Larger" ForeColor="White" Width="700px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:ListBox Font-Size="Large" ID="ListTokens" runat="server" Width="200px" ></asp:ListBox></td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:Button ID="btnPrintToken" runat="server" Text="Print Token" OnClick="btnPrintToken_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:Label ID="lblStatus" runat="server" Font-Size="Large"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
//===========================Webform1.aspx.cs=========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TokenQueue"] == null)
            {
                Queue<int> queueTokens = new Queue<int>();
                Session["TokenQueue"] = queueTokens;
            }
            
        }

        protected void btnPrintToken_Click(object sender, EventArgs e)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            lblStatus.Text = "There are" + tokenQueue.Count.ToString() + "Customer before you in the queue";
            if (Session["LastToken" +
                "NumberIssues"] == null)
            {
                Session["LastTokenNumberIssues"] = 0;
            }
            int nextTokenNumberTobeIssued = (int)Session["LastTokenNumberIssues"] + 1;
            Session["LastTokenNumberIssues"] = nextTokenNumberTobeIssued;
            tokenQueue.Enqueue(nextTokenNumberTobeIssued);
            AddTokensToListBox(tokenQueue);
        }

        private void AddTokensToListBox(Queue<int> tokenQueue)
        {
            ListTokens.Items.Clear();
            foreach (int token in tokenQueue)
            {
                ListTokens.Items.Add(token.ToString());
            }
        }


        private  void ServerNextCustomer(TextBox textbox,int CounterNumber)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            if (tokenQueue.Count <= 0)
            {
                textbox.Text = "No Customer in the queue";
            }
            else
            {
                int tokenNumberToBeServered = tokenQueue.Dequeue();
                textbox.Text = tokenNumberToBeServered.ToString();
                txtDisplay.Text = "Token Number: " + tokenNumberToBeServered.ToString() + "please  go to counter"+ CounterNumber;
                AddTokensToListBox(tokenQueue);
            }
        }
        protected void btnCounter1_Click(object sender, EventArgs e)
        {
            ServerNextCustomer(txtCounter1, 1);
        }


        protected void btnCounter2_Click(object sender, EventArgs e)
        {
            ServerNextCustomer(txtCounter2, 2);
        }

        protected void btnCounter3_Click(object sender, EventArgs e)
        {
            ServerNextCustomer(txtCounter3, 3);
        }
    }
}
