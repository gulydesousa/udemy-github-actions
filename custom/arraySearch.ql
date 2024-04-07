/**
 * @name Método con parámetro de tipo array en el namespace Facturas
 * @description Encuentra todos los métodos en el namespace Facturas que tienen un parámetro de tipo array.
 * @kind problem
 * @problem.severity warning
 * @id csharp/facturas/array-parameter
 * @tags mantenibilidad
 * @precision high
 */

 import csharp

 from Method m, Parameter p
 where m.getDeclaringType().getNamespace().getName() = "Facturas"
   and p = m.getAParameter()
   and p.getType() instanceof ArrayType
 select m, "Este método tiene un parámetro de tipo array."