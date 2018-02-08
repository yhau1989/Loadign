<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div class="ui center aligned  segment container">
        <h1 class="ui header">Default.aspx</h1>
        <div class="divided"></div>
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Button ID="Button1" OnClick="Button1_Click" CssClass="positive ui button" runat="server" Text="Load Json" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div class="divided"></div>


        <div class="ui right aligned container basic segment container">
          <p>
              <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
          </p>
        </div>

       
             
    
    </div>
    

</asp:Content>
