TYPE=VIEW
query=select `history`.`person`.`pers_FIO` AS `pers_FIO`,`history`.`person`.`pers_lifeYear` AS `pers_lifeYear`,`history`.`gallery`.`pic_name` AS `pic_name`,`history`.`type`.`type_name` AS `type_name`,`history`.`gallery`.`picture` AS `picture` from (((`history`.`gallery` join `history`.`type` on((`history`.`gallery`.`id_type` = `history`.`type`.`id_type`))) join `history`.`person_pictures` on((`history`.`person_pictures`.`id_picture` = `history`.`gallery`.`id_picture`))) join `history`.`person` on((`history`.`person_pictures`.`id_person` = `history`.`person`.`id_person`)))
md5=134162911771e171dccb42748af535e6
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-04-21 08:40:57
create-version=1
source=SELECT\n	  `person`.`pers_FIO` AS `pers_FIO`,\n	  `person`.`pers_lifeYear` AS `pers_lifeYear`,\n	  `gallery`.`pic_name` AS `pic_name`,\n	  `type`.`type_name` AS `type_name`,\n	  `gallery`.`picture` AS `picture`\n	FROM (((`gallery`\n	  JOIN `type`\n	    ON ((`gallery`.`id_type` = `type`.`id_type`)))\n	  JOIN `person_pictures`\n	    ON ((`person_pictures`.`id_picture` = `gallery`.`id_picture`)))\n	  JOIN `person`\n	    ON ((`person_pictures`.`id_person` = `person`.`id_person`)))
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `history`.`person`.`pers_FIO` AS `pers_FIO`,`history`.`person`.`pers_lifeYear` AS `pers_lifeYear`,`history`.`gallery`.`pic_name` AS `pic_name`,`history`.`type`.`type_name` AS `type_name`,`history`.`gallery`.`picture` AS `picture` from (((`history`.`gallery` join `history`.`type` on((`history`.`gallery`.`id_type` = `history`.`type`.`id_type`))) join `history`.`person_pictures` on((`history`.`person_pictures`.`id_picture` = `history`.`gallery`.`id_picture`))) join `history`.`person` on((`history`.`person_pictures`.`id_person` = `history`.`person`.`id_person`)))
