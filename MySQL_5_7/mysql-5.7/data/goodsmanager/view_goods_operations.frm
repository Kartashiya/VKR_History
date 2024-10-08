TYPE=VIEW
query=select `goodsmanager`.`operations`.`IDoperation` AS `IDoperation`,`goodsmanager`.`operations`.`oDateTime` AS `oDateTime`,`goodsmanager`.`operations`.`oIsSale` AS `oIsSale`,if((`goodsmanager`.`operations`.`oIsSale` = 1),\'Продажа\',\'Поставка\') AS `opType`,`goodsmanager`.`suppliers_catalog`.`scName` AS `scName`,`view_operations_fullcost`.`oFullCost` AS `oFullCost` from ((`goodsmanager`.`operations` left join `goodsmanager`.`suppliers_catalog` on((`goodsmanager`.`operations`.`IDsc` = `goodsmanager`.`suppliers_catalog`.`IDsc`))) left join `goodsmanager`.`view_operations_fullcost` on((`goodsmanager`.`operations`.`IDoperation` = `view_operations_fullcost`.`IDoperation`)))
md5=676a1a390adbc7a7c61b060d8d6d2026
updatable=0
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2023-05-08 14:43:43
create-version=1
source=SELECT\n	  operations.IDoperation AS IDoperation,\n	  operations.oDateTime AS oDateTime,\n	  operations.oIsSale AS oIsSale,\n	  IF(operations.oIsSale = 1, \'Продажа\', \'Поставка\') AS opType,\n	  suppliers_catalog.scName AS scName,\n	  view_operations_fullcost.oFullCost AS oFullCost\n	FROM operations\n	  LEFT OUTER JOIN suppliers_catalog\n	    ON operations.IDsc = suppliers_catalog.IDsc\n	  LEFT OUTER JOIN view_operations_fullcost\n	    ON operations.IDoperation = view_operations_fullcost.IDoperation
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `goodsmanager`.`operations`.`IDoperation` AS `IDoperation`,`goodsmanager`.`operations`.`oDateTime` AS `oDateTime`,`goodsmanager`.`operations`.`oIsSale` AS `oIsSale`,if((`goodsmanager`.`operations`.`oIsSale` = 1),\'Продажа\',\'Поставка\') AS `opType`,`goodsmanager`.`suppliers_catalog`.`scName` AS `scName`,`view_operations_fullcost`.`oFullCost` AS `oFullCost` from ((`goodsmanager`.`operations` left join `goodsmanager`.`suppliers_catalog` on((`goodsmanager`.`operations`.`IDsc` = `goodsmanager`.`suppliers_catalog`.`IDsc`))) left join `goodsmanager`.`view_operations_fullcost` on((`goodsmanager`.`operations`.`IDoperation` = `view_operations_fullcost`.`IDoperation`)))
