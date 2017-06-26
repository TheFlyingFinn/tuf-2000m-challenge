<%@ Page Title="TUF-2000M challenge" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TUF_2000M_challenge._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h3><%= date %></h3>
    <div class="table-responsive">
        <table class="table table-striped">
            <thead>
                <tr>
                    <th>REGISTER</th><th>NUMBER</th><th>VARABLE NAME</th><th>VALUE</th><th>FORMAT</th>
                </tr>
            </thead>
            <tbody>
            <% for (var i = 0; i < values.Count; i++) { %>
                <tr>
                    <td><%= (i + 1).ToString("D4") %></td>
                    <% if ((i + 1) >= 53 && (i + 1) <= 55) { %>
                    <td>3</td>
                    <% } else if ((i + 1) == 51 || ((i + 1) >= 56 && (i + 1) < 72) || ((i + 1) > 92 && (i + 1) < 97)) { %>
                    <td>1</td>
                    <% }  else { %>
                    <td>2</td>
                    <% } %>
                    <td><%= variable_name[i] %></td>
                    <td><%= values[i] %></td>
                    <td><%= format[i] %></td>
                </tr>
            <% } %>            
            </tbody>
         </table>
    </div>
</asp:Content>
