
INSERT INTO info_document_importance (id,order_number, short_name, full_name,state_id)
VALUES (1, '001', 'Стратегик', 'Стратегик аҳамиятга эга',1);

INSERT INTO info_document_importance_translate (owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (1, 1, 'full_name', 'Стратегик аҳамиятга эга'),
  -- Uzbek Latin translations
  (1, 2, 'full_name', 'Strategik ahamiyatga ega'),
  -- Russian translations
  (1, 3, 'full_name', 'Стратегически важный');
  
  									
INSERT INTO info_document_importance (id,order_number, short_name, full_name,state_id)
VALUES (2, '002', 'Назоратда', 'Назоратга олинган',1);

INSERT INTO info_document_importance_translate (owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (2, 1, 'full_name', 'Назоратга олинган'),
  -- Uzbek Latin translations
  (2, 2, 'full_name', 'Nazoratga olingan'),
  -- Russian translations
  (2, 3, 'full_name', 'Под наблюдением.');

