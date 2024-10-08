TYPE=VIEW
query=select `history`.`alphabet_dict`.`alph_char` AS `alph_cahr`,`history`.`dictionary`.`dict_definition` AS `dict_definition` from (`history`.`dictionary` join `history`.`alphabet_dict` on((`history`.`dictionary`.`id_alph` = `history`.`alphabet_dict`.`id_alph`)))
md5=a0155ce80a369e4287f978d08327c6c9
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-03-27 10:24:57
create-version=1
source=SELECT\n	  `alphabet_dict`.alph_char AS `alph_cahr`,\n	  `dictionary`.`dict_definition` AS `dict_definition`\n	FROM (`dictionary`\n	  JOIN `alphabet_dict`\n	    ON ((`dictionary`.`id_alph` = `alphabet_dict`.`id_alph`)))
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `history`.`alphabet_dict`.`alph_char` AS `alph_cahr`,`history`.`dictionary`.`dict_definition` AS `dict_definition` from (`history`.`dictionary` join `history`.`alphabet_dict` on((`history`.`dictionary`.`id_alph` = `history`.`alphabet_dict`.`id_alph`)))
