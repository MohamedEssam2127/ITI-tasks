import { Stack, Typography } from "@mui/material";
import MenuIcon from "@mui/icons-material/Menu";

export default function MyHeader() {
  return (
    <Stack
      sx={{
        bgcolor: "#303841",
        width: "100%",
        boxSizing: "border-box",
        px: { xs: 3, lg: 16 },
        justifyContent: "space-between",
        py: 2,
        alignItems: "center",
      }}
      direction="row"
    >
      <Typography variant="h5" sx={{ color: "#F5F5F5" }}>
        Restaurant
      </Typography>

      <Stack
        direction="row"
        spacing={4}
        sx={{
          display: { xs: "none", lg: "flex" },
          alignItems: "center",
        }}
      >
        <Typography sx={{ color: "#F5F5F5", cursor: "pointer" }}>Home</Typography>
        <Typography sx={{ color: "#F5F5F5", cursor: "pointer" }}>Menu</Typography>
        <Typography sx={{ color: "#F5F5F5", cursor: "pointer" }}>About</Typography>
        <Typography sx={{ color: "#F5F5F5", cursor: "pointer" }}>Contact</Typography>
      </Stack>

      <MenuIcon
        sx={{
          display: { xs: "block", lg: "none" },
          color: "#F5F5F5",
          cursor: "pointer",
        }}
      />
    </Stack>
  );
}