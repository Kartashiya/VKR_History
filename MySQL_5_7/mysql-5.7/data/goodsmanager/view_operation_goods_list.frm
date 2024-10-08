TYPE=VIEW
query=select `goodsmanager`.`op_goods_list`.`IDoperation` AS `IDoperation`,`goodsmanager`.`op_goods_list`.`IDgc` AS `IDgc`,`goodsmanager`.`op_goods_list`.`ocCount` AS `ocCount`,`goodsmanager`.`goods_catalog`.`gcName` AS `gcName`,`goodsmanager`.`goods_catalog`.`gcCost` AS `gcCost`,`goodsmanager`.`type_goods`.`tgName` AS `tgName`,(`goodsmanager`.`op_goods_list`.`ocCount` * `goodsmanager`.`goods_catalog`.`gcCost`) AS `ogcFCost` from ((`goodsmanager`.`op_goods_list` join `goodsmanager`.`goods_catalog` on((`goodsmanager`.`op_goods_list`.`IDgc` = `goodsmanager`.`goods_catalog`.`IDgc`))) join `goodsmanager`.`type_goods` on((`goodsmanager`.`goods_catalog`.`IDtg` = `goodsmanager`.`type_goods`.`IDtg`)))
md5=9af7be195aabb55fa11febc266b77d10
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2023-05-08 14:39:39
create-version=1
source=SELECT\n	  op_goods_list.IDoperation,\n	  op_goods_list.IDgc,\n	  op_goods_list.ocCount,\n	  goods_catalog.gcName,\n	  goods_catalog.gcCost,\n	  type_goods.tgName,\n	  op_goods_list.ocCount * goods_catalog.gcCost AS ogcFCost\n	FROM op_goods_list\n	  INNER JOIN goods_catalog\n	    ON op_goods_list.IDgc = goods_catalog.IDgc\n	  INNER JOIN type_goods\n	    ON goods_catalog.IDtg = type_goods.IDtg
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `goodsmanager`.`op_goods_list`.`IDoperation` AS `IDoperation`,`goodsmanager`.`op_goods_list`.`IDgc` AS `IDgc`,`goodsmanager`.`op_goods_list`.`ocCount` AS `ocCount`,`goodsmanager`.`goods_catalog`.`gcName` AS `gcName`,`goodsmanager`.`goods_catalog`.`gcCost` AS `gcCost`,`goodsmanager`.`type_goods`.`tgName` AS `tgName`,(`goodsmanager`.`op_goods_list`.`ocCount` * `goodsmanager`.`goods_catalog`.`gcCost`) AS `ogcFCost` from ((`goodsmanager`.`op_goods_list` join `goodsmanager`.`goods_catalog` on((`goodsmanager`.`op_goods_list`.`IDgc` = `goodsmanager`.`goods_catalog`.`IDgc`))) join `goodsmanager`.`type_goods` on((`goodsmanager`.`goods_catalog`.`IDtg` = `goodsmanager`.`type_goods`.`IDtg`)))
