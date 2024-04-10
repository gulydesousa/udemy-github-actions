/**
 * @name Creación de instancias de InvoiceLineType fuera de InvoiceLine.cs
 * @description Encuentra todas las instancias del objeto InvoiceLineType que se crean fuera de la clase InvoiceLine.cs.
 * @kind problem
 * @problem.severity warning
 * @id csharp/invoice-line/instance-creation
 * @tags mantenibilidad
 * @precision high
 */

 import csharp

 from ObjectCreation oc
 where oc.getType().getName() = "InvoiceLineType"
   and oc.getLocation().getFile().getBaseName() != "InvoiceLine.cs"
 select oc, "Se ha creado una instancia de InvoiceLineType fuera de InvoiceLine.cs."