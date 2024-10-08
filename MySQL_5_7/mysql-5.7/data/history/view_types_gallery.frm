TYPE=VIEW
query=select `history`.`type`.`type_name` AS `type_name`,`history`.`gallery`.`pic_name` AS `pic_name`,`history`.`gallery`.`picture` AS `picture` from (`history`.`gallery` join `history`.`type` on((`history`.`gallery`.`id_type` = `history`.`type`.`id_type`)))
md5=64274ddd9e6914dd2b49994214a378e8
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-04-21 08:49:11
create-version=1
source=SELECT\n	  type.type_name,\n	  gallery.pic_name,\n	  gallery.picture\n	FROM gallery\n	  INNER JOIN type\n	    ON gallery.id_type = type.id_type
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `history`.`type`.`type_name` AS `type_name`,`history`.`gallery`.`pic_name` AS `pic_name`,`history`.`gallery`.`picture` AS `picture` from (`history`.`gallery` join `history`.`type` on((`history`.`gallery`.`id_type` = `history`.`type`.`id_type`)))
