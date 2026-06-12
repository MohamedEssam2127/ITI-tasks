import 'package:my_first_project/my_first_project.dart' as my_first_project;


enum Environment {
  development,
  staging,
  production,
}

void main(List<String> arguments) {
  const double MAX_RATIO = 0.85;
  const String SYSTEM_CODE ='''
   line 1 
   line 2
   line 3 
   ''';
  
  Runes architecturalRune = Runes('\u{1F3D7}');
  String badgeString = String.fromCharCodes(architecturalRune);

  //4
  Set<int> mySet = {1, 2, 2, 3, 3};

  Map<String, dynamic> pipelineConfig = {
    "env": Environment.production,
    "ratio": MAX_RATIO,
    "badge": badgeString,
    "node_weights": mySet.toList(),
  };

print(" Map: $pipelineConfig");

  
print("\n============= Q2 ==================");
  //1 
  String? incomingPayload;
  int? fallbackMetric;

 //2
  incomingPayload ??= "GUEST_STREAM";
  fallbackMetric ??= 404;


  String? userToken;
  String activeToken = userToken ?? incomingPayload;

  int finalSystemLength = incomingPayload!.length;
//4
  print("incomingPayload: $incomingPayload");
  print("fallbackMetric: $fallbackMetric");
  print("activeToken: $activeToken");
  print("finalSystemLength: $finalSystemLength");
}
