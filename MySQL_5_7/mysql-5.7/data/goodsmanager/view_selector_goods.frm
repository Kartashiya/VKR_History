TYPE=VIEW
query=select `goodsmanager`.`goods_catalog`.`IDgc` AS `IDgc`,concat(`goodsmanager`.`goods_catalog`.`gcName`,\' [\',`goodsmanager`.`goods_catalog`.`gcCost`,\' руб.]\') AS `sNameCost`,`goodsmanager`.`storage`.`sCount` AS `sCount` from (`goodsmanager`.`storage` join `goodsmanager`.`goods_catalog` on((`goodsmanager`.`storage`.`IDgc` = `goodsmanager`.`goods_catalog`.`IDgc`)))
md5=bb3eded3cb47016b8ada9265e14f6822
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2023-05-08 14:46:24
create-version=1
source=SELECT\n	  goods_catalog.IDgc,\n	  CONCAT(goods_catalog.gcName, \' [\', goods_catalog.gcCost, \' руб.]\') AS sNameCost,\n	  storage.sCount\n	FROM storage\n	  INNER JOIN goods_catalog\n	    ON storage.IDgc = goods_catalog.IDgc
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `goodsmanager`.`goods_catalog`.`IDgc` AS `IDgc`,concat(`goodsmanager`.`goods_catalog`.`gcName`,\' [\',`goodsmanager`.`goods_catalog`.`gcCost`,\' руб.]\') AS `sNameCost`,`goodsmanager`.`storage`.`sCount` AS `sCount` from (`goodsmanager`.`storage` join `goodsmanager`.`goods_catalog` on((`goodsmanager`.`storage`.`IDgc` = `goodsmanager`.`goods_catalog`.`IDgc`)))
