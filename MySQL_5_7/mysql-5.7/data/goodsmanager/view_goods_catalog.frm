TYPE=VIEW
query=select `goodsmanager`.`goods_catalog`.`IDgc` AS `IDgc`,`goodsmanager`.`goods_catalog`.`gcName` AS `gcName`,`goodsmanager`.`goods_catalog`.`gcDescription` AS `gcDescription`,`goodsmanager`.`goods_catalog`.`gcPhoto` AS `gcPhoto`,`goodsmanager`.`goods_catalog`.`gcCost` AS `gcCost`,`goodsmanager`.`type_goods`.`tgName` AS `tgName` from (`goodsmanager`.`goods_catalog` join `goodsmanager`.`type_goods` on((`goodsmanager`.`goods_catalog`.`IDtg` = `goodsmanager`.`type_goods`.`IDtg`)))
md5=6a6a3aa14d6bcd9de19e3e7e0991855f
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2023-05-03 16:55:01
create-version=1
source=SELECT\n	  goods_catalog.IDgc,\n	  goods_catalog.gcName,\n	  goods_catalog.gcDescription,\n	  goods_catalog.gcPhoto,\n	  goods_catalog.gcCost,\n	  type_goods.tgName\n	FROM goods_catalog\n	  INNER JOIN type_goods\n	    ON goods_catalog.IDtg = type_goods.IDtg
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `goodsmanager`.`goods_catalog`.`IDgc` AS `IDgc`,`goodsmanager`.`goods_catalog`.`gcName` AS `gcName`,`goodsmanager`.`goods_catalog`.`gcDescription` AS `gcDescription`,`goodsmanager`.`goods_catalog`.`gcPhoto` AS `gcPhoto`,`goodsmanager`.`goods_catalog`.`gcCost` AS `gcCost`,`goodsmanager`.`type_goods`.`tgName` AS `tgName` from (`goodsmanager`.`goods_catalog` join `goodsmanager`.`type_goods` on((`goodsmanager`.`goods_catalog`.`IDtg` = `goodsmanager`.`type_goods`.`IDtg`)))
