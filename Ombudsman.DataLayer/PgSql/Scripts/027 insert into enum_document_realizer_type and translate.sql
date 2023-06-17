INSERT INTO enum_document_realizer_type(id,order_number, short_name, full_name,state_id)
VALUES (1, '001', 'Модератор', 'Модератор',1);

INSERT INTO enum_document_realizer_type_translate 
(owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (1, 1, 'full_name', 'Модератор'),
  -- Uzbek Latin translations
  (1, 2, 'full_name', 'Moderator'),
  -- Russian translations
  (1, 3, 'full_name', 'Модератор'); 
  
  INSERT INTO enum_document_realizer_type(id,order_number, short_name, full_name,state_id)
VALUES (2, '002', 'Асосий Ижрочи', 'Асосий Ижрочи',1);

INSERT INTO enum_document_realizer_type_translate 
(owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (2, 1, 'full_name', 'Асосий Ижрочи'),
  -- Uzbek Latin translations
  (2, 2, 'full_name', 'Asosiy Ijrochi'),
  -- Russian translations
  (2, 3, 'full_name', 'Главный исполнитель'); 
  
INSERT INTO enum_document_realizer_type(id,order_number, short_name, full_name,state_id)
VALUES (3, '003', 'Модератор', 'Модератор',1);

INSERT INTO enum_document_realizer_type_translate 
(owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (3, 1, 'full_name', 'Қўшимча Ижрочи'),
  -- Uzbek Latin translations
  (3, 2, 'full_name', 'Qo`shimcha Ijrochi'),
  -- Russian translations
  (3, 3, 'full_name', 'Дополнительный исполнительный'); 
