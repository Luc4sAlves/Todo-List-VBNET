﻿@ModelType IEnumerable(Of Todo_List.Task)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div>
    <h2>To Do</h2>
   
</div>


<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DueDate)
            <a class="nav-link" asp-area="" asp-controller ="Tasks" asp-action ="SortByDueDate">v</a>
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Priority)
            @Html.ActionLink("v", "SortByPriority", "Tasks", New With {.htmlAttributes = New With {.Class = "sort-link"}})
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Criticality)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @Code
        Dim cssClass = ""
        If item.DueDate < Today Then
            cssClass = "alert-danger"
        End If
    End Code
    @<tr class=@cssClass>
        <td>
            <span class= "alert-due">@Html.DisplayFor(Function(modelItem) item.Description)</span>
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DueDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Priority)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Criticality)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id}) |
            @*@Html.ActionLink("Details", "Details", New With {.id = item.id}) |*@
            @Html.ActionLink("Finish ✔", "Delete", New With {.id = item.id})
        </td>
    </tr>
        Next

</table>