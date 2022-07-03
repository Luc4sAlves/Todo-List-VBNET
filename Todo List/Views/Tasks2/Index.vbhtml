@ModelType IEnumerable(Of Todo_List.Task)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

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
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Priority)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Criticality)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Category.CategoryName)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Description)
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
            @Html.DisplayFor(Function(modelItem) item.Category.CategoryName)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id })
        </td>
    </tr>
Next

</table>
