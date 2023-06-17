
INSERT INTO enum_document_type (id,order_number, short_name, full_name,state_id)
VALUES (1, '001', 'ҚЛ', 'Қонун Лойихаси',1);

INSERT INTO enum_document_type_translate (owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (1, 1, 'full_name', 'Қонун Лойихаси'),
  -- Uzbek Latin translations
  (1, 2, 'full_name', 'Qonun Loyixasi'),
  -- Russian translations
  (1, 3, 'full_name', 'Законопроект');		
  
  
INSERT INTO enum_document_type (id,order_number, short_name, full_name,state_id)
VALUES (2, '002', 'ПФ', 'Президент Фармони',1);

INSERT INTO enum_document_type_translate (owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (2, 1, 'full_name', 'Президент Фармони'),
  -- Uzbek Latin translations
  (2, 2, 'full_name', 'Prezident Farmoni'),
  -- Russian translations
  (2, 3, 'full_name', 'Указ Президента');

   
  
INSERT INTO enum_document_type (id,order_number, short_name, full_name,state_id)
VALUES (3,'003', 'ПҚ', 'Президент Қарори',1);

INSERT INTO enum_document_type_translate (owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (3, 1, 'full_name', 'Президент Қарори'),
  -- Uzbek Latin translations
  (3, 2, 'full_name', 'Prezident Qarori'),
  -- Russian translations
  (3, 3, 'full_name', 'Указ Президента');

   
  
INSERT INTO enum_document_type (id,order_number, short_name, full_name,state_id)
VALUES (4, '004', 'ПФр', 'Президент Фармойиши',1);

INSERT INTO enum_document_type_translate (owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (4, 1, 'full_name', 'Президент Фармойиши'),
  -- Uzbek Latin translations
  (4, 2, 'full_name', 'Prezident Farmoyishi'),
  -- Russian translations
  (4, 3, 'full_name', 'Указ Президента');

   
  
INSERT INTO enum_document_type (id,order_number, short_name, full_name,state_id)
VALUES (5, '005', 'ВМҚ', 'Вазирлар маҳкамаси қарори',1);

INSERT INTO enum_document_type_translate (owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (5, 1, 'full_name', 'Вазирлар маҳкамаси қарори'),
  -- Uzbek Latin translations
  (5, 2, 'full_name', 'Vazirlar mahkamasi qarori'),
  -- Russian translations
  (5, 3, 'full_name', 'Решение кабинета министров');


INSERT INTO enum_document_type (id,order_number, short_name, full_name,state_id)
VALUES (6, '006', 'ПФ', 'Меморандум',1);

INSERT INTO enum_document_type_translate (owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (6, 1, 'full_name', 'Меморандум'),
  -- Uzbek Latin translations
  (6, 2, 'full_name', 'Memorandum'),
  -- Russian translations
  (6, 3, 'full_name', 'Докладная записка');