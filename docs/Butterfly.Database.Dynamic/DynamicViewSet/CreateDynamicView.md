# DynamicViewSet.CreateDynamicView method

Creates an instance of a DynamicView. Must call StartAync() to send initial DataEventTransaction and listen for new DataEventTransactions for this DynamicView.

```csharp
public DynamicView CreateDynamicView(string sql, object values = null, string name = null, string[] keyFieldNames = null)
```

## See Also

* class [DynamicView](../DynamicView.md)
* class [DynamicViewSet](../DynamicViewSet.md)
* namespace [Butterfly.Database.Dynamic](../../Butterfly.Database.md)

<!-- DO NOT EDIT: generated by xmldocmd for Butterfly.Database.dll -->