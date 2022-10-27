namespace WebLinqExercises.Data;

public static class TableHelper
{
    public static string ToHtmlTable<T>(this List<T> listOfClassObjects)
    {
        var ret = string.Empty;

        return listOfClassObjects == null || !listOfClassObjects.Any()
            ? ret
            : "<table class='table'><tbody>" +
              listOfClassObjects.First().GetType().GetProperties().Select(p => p.Name).ToList().ToColumnHeaders() +

              listOfClassObjects.Aggregate(ret, (current, t) => current + t.ToHtmlTableRow()) +
              "</tbody></table>";
    }

    public static string ToColumnHeaders<T>(this List<T> listOfProperties)
    {
        var ret = string.Empty;

        return listOfProperties == null || !listOfProperties.Any()
            ? ret
            : "<tr>" +
              listOfProperties.Aggregate(ret,
                  (current, propValue) =>
                      current +
                      ("<th>" +
                       (Convert.ToString(propValue).Length <= 100
                           ? Convert.ToString(propValue)
                           : Convert.ToString(propValue).Substring(0, 100)) + "..." + "</th>")) +
              "</tr>";
    }

    public static string ToHtmlTableRow<T>(this T classObject)
    {
        var ret = string.Empty;

        return classObject == null
            ? ret
            : "<tr>" +
              classObject.GetType()
                  .GetProperties()
                  .Aggregate(ret,
                      (current, prop) =>
                          current + ("<td>" +
                                     (Convert.ToString(prop.GetValue(classObject, null)).Length <= 100
                                         ? Convert.ToString(prop.GetValue(classObject, null))
                                         : Convert.ToString(prop.GetValue(classObject, null)).Substring(0, 100) +
                                           "...") +
                                     "</td>")) + "</tr>";
    }
}