TYPE=VIEW
query=select `view_operation_goods_list`.`IDoperation` AS `IDoperation`,sum(`view_operation_goods_list`.`ogcFCost`) AS `oFullCost` from `goodsmanager`.`view_operation_goods_list` group by `view_operation_goods_list`.`IDoperation`
md5=c088aaf83dbe90acdcee439e0f45f273
updatable=0
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2023-05-08 14:41:30
create-version=1
source=SELECT\n	  IDoperation AS IDoperation,\n	  SUM(ogcFCost) AS oFullCost\n	FROM view_operation_goods_list\n	GROUP BY IDoperation
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `view_operation_goods_list`.`IDoperation` AS `IDoperation`,sum(`view_operation_goods_list`.`ogcFCost`) AS `oFullCost` from `goodsmanager`.`view_operation_goods_list` group by `view_operation_goods_list`.`IDoperation`
