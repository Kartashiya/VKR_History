TYPE=TRIGGERS
triggers='CREATE DEFINER=`root`@`localhost` TRIGGER tr_add_goods_in_catalog\n	AFTER INSERT\n	ON goods_catalog\n	FOR EACH ROW\nBEGIN\nINSERT INTO storage SET IDgc = NEW.IDgc, sCount = 0;\nEND' 'CREATE DEFINER=`root`@`localhost` TRIGGER tr_remove_goods_from_catalog\n	BEFORE DELETE\n	ON goods_catalog\n	FOR EACH ROW\nBEGIN\nDELETE FROM storage WHERE (IDgc = OLD.IDgc) AND (sCount = 0);\nEND'
sql_modes=1436549152 1436549152
definers='root@localhost' 'root@localhost'
client_cs_names='utf8' 'utf8'
connection_cl_names='utf8_general_ci' 'utf8_general_ci'
db_cl_names='utf8mb4_general_ci' 'utf8mb4_general_ci'
created=168313177307 168313184137
