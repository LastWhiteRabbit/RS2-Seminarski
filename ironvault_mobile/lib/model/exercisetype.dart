import 'dart:convert';

import 'package:json_annotation/json_annotation.dart';

part 'exercisetype.g.dart';

@JsonSerializable()
class ExerciseType {
  int? exerciseTypeId;
  String? exerciseTypeName;

  ExerciseType() {}

  factory ExerciseType.fromJson(Map<String, dynamic> json) =>
      _$ExerciseTypeFromJson(json);

  Map<String, dynamic> toJson() => _$ExerciseTypeToJson(this);
}
