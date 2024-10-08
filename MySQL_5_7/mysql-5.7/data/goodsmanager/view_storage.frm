TYPE=VIEW
query=select `goodsmanager`.`storage`.`IDstorage` AS `IDstorage`,`goodsmanager`.`storage`.`IDgc` AS `IDgc`,`goodsmanager`.`goods_catalog`.`gcName` AS `gcName`,`goodsmanager`.`goods_catalog`.`IDtg` AS `IDtg`,`goodsmanager`.`type_goods`.`tgName` AS `tgName`,`goodsmanager`.`storage`.`sCount` AS `sCount` from ((`goodsmanager`.`storage` join `goodsmanager`.`goods_catalog` on((`goodsmanager`.`storage`.`IDgc` = `goodsmanager`.`goods_catalog`.`IDgc`))) join `goodsmanager`.`type_goods` on((`goodsmanager`.`goods_catalog`.`IDtg` = `goodsmanager`.`type_goods`.`IDtg`)))
md5=fb4d582a98754989935d0aedea198ba0
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2023-05-03 16:59:38
create-version=1
source=SELECT\n	  storage.IDstorage,\n	  storage.IDgc,\n	  goods_catalog.gcName,\n	  goods_catalog.IDtg,\n	  type_goods.tgName,\n	  storage.sCount\n	FROM storage\n	  INNER JOIN goods_catalog\n	    ON storage.IDgc = goods_catalog.IDgc\n	  INNER JOIN type_goods\n	    ON goods_catalog.IDtg = type_goods.IDtg
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `goodsmanager`.`storage`.`IDstorage` AS `IDstorage`,`goodsmanager`.`storage`.`IDgc` AS `IDgc`,`goodsmanager`.`goods_catalog`.`gcName` AS `gcName`,`goodsmanager`.`goods_catalog`.`IDtg` AS `IDtg`,`goodsmanager`.`type_goods`.`tgName` AS `tgName`,`goodsmanager`.`storage`.`sCount` AS `sCount` from ((`goodsmanager`.`storage` join `goodsmanager`.`goods_catalog` on((`goodsmanager`.`storage`.`IDgc` = `goodsmanager`.`goods_catalog`.`IDgc`))) join `goodsmanager`.`type_goods` on((`goodsmanager`.`goods_catalog`.`IDtg` = `goodsmanager`.`type_goods`.`IDtg`)))
