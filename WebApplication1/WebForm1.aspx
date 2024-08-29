<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>29-08-2024</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server" class="container mt-4">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="mb-3">
                    <asp:Label ID="lblUsername" runat="server" Text="Username" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="username" runat="server" placeholder="Enter Username" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblPassword" runat="server" Text="Password" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="password" runat="server" placeholder="Enter Password" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3 text-center">
                    <asp:Button ID="btnClr" runat="server" Text="Update" OnClick="btnClear" CssClass="btn btn-primary" ></asp:Button>
                     <asp:Button ID="btnSub" runat="server" Text="Submit" OnClick="btnSubmit" CssClass="btn btn-primary" ></asp:Button>
                </div>
                <div class="mb-3 text-center">
                    <asp:Label ID="Msg" runat="server" ForeColor="Red"></asp:Label>
                </div>
                <asp:GridView ID="grdData" runat="server" CssClass="table table-striped table-bordered" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="UID" HeaderText="UID" ReadOnly="True" SortExpression="UID" />
                        <asp:BoundField DataField="username" HeaderText="Username" SortExpression="username" />
                        <asp:BoundField DataField="password" HeaderText="Password" SortExpression="password" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
