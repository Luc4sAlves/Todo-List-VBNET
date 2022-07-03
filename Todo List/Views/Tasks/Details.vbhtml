@ModelType Todo_List.Task
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Task Details</h2>

<div>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DueDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DueDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Priority)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Priority)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Criticality)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Criticality)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
